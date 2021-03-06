﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace Memoria.Patcher
{
    class Program
    {
        public static volatile Boolean Changed;

        public static readonly PatchCollection<TypePatch> Patches = InitializePatches();

        private static PatchCollection<TypePatch> InitializePatches()
        {
            return new PatchCollection<TypePatch>(
                new TypePatch[]
                {
                    new DefaultFontPatch(),
                    new FF9TextToolPatch()
                });
        }

        static void Main(String[] args)
        {
            try
            {
                GameLocationInfo gameLocation = GetGameLocation(args);
                if (gameLocation == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0}.exe <gamePath>", Assembly.GetExecutingAssembly().GetName().Name);
                    Console.WriteLine("Press enter to exit...");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

                ReplaceLauncher(gameLocation);
                ReplaceDebugger(gameLocation);
                CopyExternalFiles(gameLocation.StreamingAssetsPath);
                Patch(gameLocation.ManagedPathX64);
                Patch(gameLocation.ManagedPathX86);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error has occurred. See [{Log.LogFileName}] for details.");
                Console.WriteLine(ex);

                Log.Error(ex, "Unexpected error.");
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        private static void ReplaceLauncher(GameLocationInfo gameLocation)
        {
            String sourceDirectory = Path.GetFullPath("Launcher");
            if (!Directory.Exists(sourceDirectory))
                throw new DirectoryNotFoundException("Launcher's directory was not found: " + sourceDirectory);

            String backupPath = Path.ChangeExtension(gameLocation.LauncherPath, ".bak");
            if (!File.Exists(backupPath))
            {
                Console.WriteLine("Back up a launcher.");
                File.Copy(gameLocation.LauncherPath, backupPath);
            }

            Console.WriteLine("Copy a launcher...");
            foreach (String sourcePath in Directory.EnumerateFiles(sourceDirectory, "*", SearchOption.TopDirectoryOnly))
            {
                if (!sourcePath.StartsWith(sourceDirectory))
                    throw new InvalidDataException(sourcePath);

                String relativePath = sourcePath.Substring(sourceDirectory.Length);
                relativePath = relativePath.Replace("Memoria.Launcher", "FF9_Launcher");
                String targetPath = gameLocation.RootDirectory + relativePath;

                File.Copy(sourcePath, targetPath, true);
                Console.WriteLine("Copied: " + targetPath);

            }
            Console.WriteLine("The launcher was copied!");
        }

        private static void ReplaceDebugger(GameLocationInfo gameLocation)
        {
            String sourceDirectory = Path.GetFullPath("Debugger");
            if (!Directory.Exists(sourceDirectory))
                throw new DirectoryNotFoundException("Debugger's directory was not found: " + sourceDirectory);

            Console.WriteLine("Copy a debugger...");

            String targetDirectory = Path.Combine(gameLocation.RootDirectory, "Debugger");
            Directory.CreateDirectory(targetDirectory);

            foreach (String sourcePath in Directory.EnumerateFileSystemEntries(sourceDirectory, "*", SearchOption.AllDirectories))
            {
                if (!sourcePath.StartsWith(sourceDirectory))
                    throw new InvalidDataException(sourcePath);

                String relativePath = sourcePath.Substring(sourceDirectory.Length);
                String targetPath = targetDirectory + relativePath;

                if ((File.GetAttributes(sourcePath) & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Directory.CreateDirectory(targetPath);
                }
                else
                {
                    File.Copy(sourcePath, targetPath, true);
                    Console.WriteLine("Copied: " + targetPath);
                }

            }
            Console.WriteLine("The debugger was copied!");
        }

        private static void CopyExternalFiles(String targetDirectory)
        {
            if (!Directory.Exists(targetDirectory))
                throw new DirectoryNotFoundException("StreamingAssets directory does not exist: " + targetDirectory);

            CopyData(targetDirectory);
            CopyScripts(targetDirectory);
        }

        private static void CopyData(String targetDirectory)
        {
            String sourceDirectory = Path.GetFullPath("Data");
            if (!Directory.Exists(sourceDirectory))
                throw new DirectoryNotFoundException("Data files was not found: " + sourceDirectory);

            targetDirectory = Path.Combine(targetDirectory, "Data");

            Console.WriteLine("Copy data files...");
            CopyFiles(targetDirectory, sourceDirectory, "*.csv");
            Console.WriteLine("Data files was copied!");
        }

        private static void CopyScripts(String targetDirectory)
        {
            String sourceDirectory = Path.GetFullPath("Scripts");
            if (!Directory.Exists(sourceDirectory))
                throw new DirectoryNotFoundException("Script files was not found: " + sourceDirectory);

            targetDirectory = Path.Combine(targetDirectory, "Scripts");

            Console.WriteLine("Copy script files...");
            CopyFiles(targetDirectory, sourceDirectory, "*.*");
            Console.WriteLine("Script files was copied!");
        }

        private static void CopyFiles(String targetDirectory, String sourceDirectory, String extensions)
        {
            foreach (String sourceFile in Directory.EnumerateFiles(sourceDirectory, extensions, SearchOption.AllDirectories))
            {
                String targetFile = targetDirectory + sourceFile.Substring(sourceDirectory.Length);
                if (File.Exists(targetFile))
                    continue;

                String directoryName = Path.GetDirectoryName(targetFile);
                if (directoryName != null)
                    Directory.CreateDirectory(directoryName);

                File.Copy(sourceFile, targetFile);
                Console.WriteLine("Copied: " + targetFile);
            }
        }

        private static void Patch(String directory)
        {
            try
            {
                if (!Directory.Exists(directory))
                {
                    Console.WriteLine("Directory does not exist: {0}", directory);
                    return;
                }

                Console.WriteLine("Patching...");

                String modPath = Path.Combine(directory, "Memoria.dll");
                File.Copy("Memoria.dll", modPath, true);
                File.Copy("Memoria.dll.mdb", modPath + ".mdb", true);

                String assemblyPath = Path.Combine(directory, "Assembly-CSharp.dll");
                String backupPath = Path.Combine(directory, "Assembly-CSharp.bak");

                RollbackPreviousPatches(assemblyPath, backupPath);

                InitializePatches();

                AssemblyDefinition mod = AssemblyDefinition.ReadAssembly(modPath);
                foreach (ModuleDefinition module in mod.Modules)
                    PreparePatch(module);

                AssemblyDefinition victim = AssemblyDefinition.ReadAssembly(assemblyPath);
                //JunkChecker.Check(victim, backupPath);

                foreach (ModuleDefinition module in victim.Modules)
                    PatchModule(module);

                TypeExporters.Export(mod, victim);

                if (Changed)
                {
                    String tmpPath = Path.Combine(directory, "Assembly-CSharp.tmp");
                    victim.Write(tmpPath);

                    if (!File.Exists(backupPath))
                        File.Copy(assemblyPath, backupPath);

                    File.Delete(assemblyPath);
                    File.Move(tmpPath, assemblyPath);
                }

                Console.WriteLine("Success!");
            }
            catch (Exception ex)
            {
                String message = $"Failed to patch assembly from a directory [{directory}]";
                Console.WriteLine(message);
                Log.Error(ex, message);
            }
        }

        private static void RollbackPreviousPatches(String assemblyPath, String backupPath)
        {
            AssemblyDefinition unknown = AssemblyDefinition.ReadAssembly(assemblyPath);

            if (unknown.MainModule.AssemblyReferences.FirstOrDefault(a => a.Name == "Memoria") == null)
            {
                if (File.Exists(backupPath))
                    File.Delete(backupPath);

                File.Copy(assemblyPath, backupPath);
            }
            else
            {
                if (File.Exists(backupPath))
                {
                    File.Delete(assemblyPath);
                    File.Copy(backupPath, assemblyPath);
                }
                else
                {
                    throw new FileNotFoundException("Assembly alreday patched and backup not found. Restore original files and try again. Expected file: " + backupPath, backupPath);
                }
            }
        }

        private static GameLocationInfo GetGameLocation(String[] args)
        {
            try
            {
                GameLocationInfo result;
                if (args.IsNullOrEmpty())
                {
                    if (File.Exists(GameLocationInfo.LauncherName))
                    {
                        result = new GameLocationInfo(Environment.CurrentDirectory);
                        result.Validate();
                    }
                    else
                    {
                        result = GameLocationSteamRegistryProvider.TryLoad();
                    }
                }
                else
                {
                    result = new GameLocationInfo(args[0]);
                    result.Validate();
                }
                return result;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to get a game location.");
                Console.WriteLine($"Failed to get a game location. See [{Log.LogFileName}] for details.");
                return null;
            }
        }

        private static void PreparePatch(ModuleDefinition module)
        {
            PrepareTypePatches(module.Types);
        }

        private static void PrepareTypePatches(Collection<TypeDefinition> types)
        {
            Int32 count = 0;
            foreach (TypeDefinition type in types)
            {
                var patch = Patches.FindByTarget(type.FullName);
                if (patch == null)
                    continue;

                patch.TargetType = type;
                if (++count >= Patches.Count)
                    break;
            }
        }

        private static void PatchModule(ModuleDefinition module)
        {
            PatchTypes(module.Types);
            PatchReferences(module.AssemblyReferences);
        }

        private static void PatchReferences(Collection<AssemblyNameReference> references)
        {
            for (Int32 i = references.Count - 1; i >= 0; i--)
            {
                AssemblyNameReference reference = references[i];
                if (reference.Name != "mscorlib")
                    continue;
                if (reference.Version == new Version(2, 0, 5, 0))
                    continue;

                throw new InvalidDataException();
            }
        }

        private static void PatchTypes(Collection<TypeDefinition> types)
        {
            Int32 count = 0;
            foreach (TypeDefinition type in types)
            {
                TypePatch patch = Patches.FindBySource(type.FullName);
                if (patch == null)
                    continue;

                PatchType(type, patch);
                if (++count >= Patches.Count)
                    break;
            }
        }

        private static void PatchType(TypeDefinition type, TypePatch patch)
        {
            PatchMethods(type.Methods, patch.GetMethodPatches());
        }

        private static void PatchMethods(Collection<MethodDefinition> methods, PatchCollection<MethodPatch> patches)
        {
            Int32 count = 0;
            foreach (MethodDefinition method in methods)
            {
                MethodPatch patch = patches.FindBySource(method.Name);
                if (patch == null)
                    continue;

                Boolean? result = IsApplicable(method, patch);
                if (result == false)
                    continue;

                if (result == true)
                {
                    patch.Patch(method);
                    Changed = true;
                }

                if (++count >= patches.Count)
                    break;
            }
        }

        private static Boolean? IsApplicable(MethodDefinition method, MethodPatch patch)
        {
            if (method.ReturnType.FullName != patch.ExpectedReturnType)
                return false;

            if (method.HasParameters)
            {
                if (patch.ExpectedParameterTypes.IsNullOrEmpty())
                    return false;

                if (method.Parameters.Count != patch.ExpectedParameterTypes.Length)
                    return false;

                for (Int32 i = 0; i < method.Parameters.Count; i++)
                {
                    if (method.Parameters[i].ParameterType.FullName != patch.ExpectedParameterTypes[i])
                        return false;
                }
            }
            else if (!patch.ExpectedParameterTypes.IsNullOrEmpty())
            {
                return false;
            }

            Collection<Instruction> instructions = method.Body.Instructions;
            return (instructions.Count < 1 || instructions[0].Operand as String != patch.Label) ? (Boolean?)true : null;
        }


    }
}