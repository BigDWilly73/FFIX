﻿extern alias Original;
using System;
using Assets.Sources.Scripts.EventEngine.Utils;
using System.IO;
using Memoria;
using UnityEngine;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable RedundantAssignment

[ExportedType("ĄÕ:õńńńń[!!!:Ĕ¶įçJĜ*ĈHáĞr¶ĈĂĊd÷łtÎĄĉĉ¸ĉłyċ42J±G+ĄĤ3Ĥ'rx1ê6³äñXĨĒçBĕĶīll7Üıh7õIf7ĶĿ/ĨġR¯Ķ9±@QĢğqĶcÁħQYºĬNßóß}¶²>NĩËĔ}»ĊĊcĊÈďh6X¯Rzę@ê*ÒäĪĤÞġķĹAøFÏİĔľ_DN/ħS´ĶG²%Qg¥*NÄáĀ}ěë?L+ėöcÍËûh¨/¯ŁmÁķHÒðê¡`L£ĿĚāď¤ęßJF°*ÐŁÚĹĹþxHĿTĠ9bòîiċv¤¹5?Û¹Åø>rçÓħ²ĉZP!!!©ö3°B¨Î+Ð3¥öĈĊ|ÚćVg~Á»ji:ĲxėPTğßê+f¾déDĀáöČêĩ8©J¯£¹µ8¬ĭŀzüĆä¸·õbxªĻëĪÇľĲPļèĠ5Đĺwîģ2Ĥzæ±ñÍ6³5Ĩ{$O=H*k$¢4T=$+dR^SĄLĮª½įåħõç11Xr2ëV¢bĸĳđäJĲÊýĐèÙÀľ7ÒÄh'1bĠĎ,ÐĲQc5¶B$ĲÀĘ?Ĩ7H#ĶĤĂģOjRĩČlD¹ouQ%!!!Ìöl)ńńńń##!!õ¬ĢŁÏăÔķľı´ĥ8Ĵ¼ĥzw·ĥVZÀĥıĸUgÇ6ÄĥÐāÄØĖ9º.ıËĂ~ĸÉûZi_ÈĨÌ¦ÆĨ©hËĨr`ÆZñĠËZdtĩôăÛāÉü¯VćŁÖÈÉ`çç<m±ÌÉĲąÏÄ­úÏÉĨ©´ĠĻ/ÓÉ¶GR©ğĝô@q¡Îġrĸ'.¢ù(ąñ`xÕëĔÿě¾ĹÂŃ_ĝĲĀãınkDÚÿĦZĹ,m9ēÀ{üĚĻ©]?ó¢ē²¢Åvę~:Ā6,ĤĈáõ#ēW@>õ8ÍĒŁwÒĽüĖĸB&{Îd%Y¡ĿķļāM¨ĴĆB[Ĳ~đ)ÂĢêÙćļËĸ·ÇĢÒW5¿á|q'÷ĉķ1#ãĄúîèÎAEUĴHĂ»Ì!¡ĽAěú·ĝÒ¶Øy|ŁNLğ'qyµĞ´łĥ$ĲÎý­VØġ¨¦ľ+7*vÕMqsI-Ċ?tānĂóF¤&ĄÛzØĳĎ·l8øq9+1U§<ð7aªÎò5¼Ğû®Òöµh}ēQĈĥĄjýè±E,ćCÝ;8®ÏFm£čŀıqN/Å)áēh»íĝĈüÂ{ľĞ¾ļuSċÞċ¦ĿjÚýk¼.ÆöDósÈĥ7ĂØ¬ü8ì°:ÿ-¥4yHB-ï]«þpØĂËěĩ©ĥ¥Ĺpý}Ĥĵ®ýw7Ĩĝæ+Đ¼oä0@H$UH¨Ħ¸C¾ºĸköØ]ąÛĎĿZ°3kĸÆĔāĆ«.ØÂĨª»Øĺ{F´ÊWč°ÖńHăl-ĦRċvr@|İQfxČĝkzĐĸ³ĚÒ@dG*÷Ąð¢Áµs8lµď£·éÓĕA58¢ÞħaĈłŀĔ!0OĳýNLđp]¾Ý~xÈĠĘÝĞ¾ëĈâĉrÚO¨ā^BīĴĽ>Ïè^Čnl¼òĩx`ęßz~ĘąĪ£BċnĆÂĳéýĠÞüÔ4ĮXzA>ăĳT:¼¡ßċķ¾ĎŁěZ&Ł&hrĚĴļôĀ[ù_ķġĀ¤|_ıùFDºäÅùL´ĭ3gÚYKÉĜńÂĂ[Ñg¸wYĥ%ıÏ÷Ô»~ãÏ'Øę@¿ďĩ|Kèĕ¹įYĠÏ[OIÿBúD4º<*ô×¦ìĚěGL!TtPéXďúã²ġåÇ@ĦÇ~jĶK=ÉjĀqöċüÃŀuČĥ»ĿĬĎnsē:ĳàĵĲď?ŁĝĔ?¶*č9dU[ļÃUy³gUÜĘeUĮzÉıĢÌĈd%Èģĸgăxķ3ıÌû¥)Î°ÑļHĦ4øÓć¢ďÃúzFĘ-2VÝĦİxĜĆÞ¾Ń£ńYèĩr:âHYöÐĂďĖ}ºĄBæ·īĆĖċěºë÷åéĪ¾9D¬Ĵ#ĠQò%*Ê£ğ=Ä»5@ªËĺ#ġBÓëĘX,¬ĐMīqñüĳÀ=$9ģĔÜćÎ`stWñ´wďÒêĴą4¯kĹhĄİľ_Đõĕą-µĘEÙ/ÜÙ^ÙâľİÞàľä0ńJèÎo»rãv¦ùŃØ¥|¡¸ĳ#OHčĐõ>©¬8ĠóŃ¬Gùı±ģĉöpºÌâ·£ç®ńńńńńńńńp¯ıįńńńń5!!!õ¬ĢŁ&=đhÌÓv^ùďoü©VwC!Ü»~ãÒ$AôQÏÚĉGaęĺ¿Đçý´~$®ăéĖăóBäĳ7Ð_ùlê×Båĭ¢M:łępĥ¹BZâ£÷ńńńńńńńńTFÇčńńńńÁ!!!õ¬ĢŁęç.ø~ĆW:ÓIħrĪ¯!ûċsď<Ç¥f+tQě<¬ħĴÙ·Ď!ĆÛYÖ_-©İ·¾ÝĐÙ©ĒÛþéģ¿¡íVĀÃV¸XµñzĄö¨:ubğÞĵ0¢ĭÔ=GČ;ĈnīĥăŀČÀ,gåuRä­í¸­CÓ¸JąHü'¿=üÚgĪW{ĸ¸WĽ0~đrđĔą¬>6¹įēCüOĴðñċT²ĒÍlÄĝÝé¦¿ăpï®QĠ[½9ķ½@è,Nm÷¹`ŀ×'XĩÉMģ3BöÆ&É÷Í&Úį÷¡éGæË)Tm39vä±êµlĻĲė§_qĄľİĈĿ+Ąg6ôßpÚĆö?ø6ĎU6Ĭŀ°ă¹ïçĔĦīē`õÖ0ÑK(ÑÁtķăÕjMÏv¦ı±zjÁ}<tMPR­ı:ĒE3ĩÃ³cäĝĶyòQÞąãī°ıĀc¿«İP«Č3×F«ĔÑĕÿîĸđkĺ!KÖĶË,gFü%ģYrmÖĴÁ<ĻÅğwpĩáě§FgAêīÐ¤µĔçĠ:£ęYAĀħÁä¦×*¢ÝKŃēD=¸įÕéAĶºU]ìĔ#ģ_ĦÏĽr¬T~9PÜOÄČĔ·ńêĝįİ:IÌÏóâĻ¥pľ/´N,,´c£zŀlrėÂ)uô$w6ÎĲa0GQã§Öķ·é0ŀEÎ$|çĦÉćíÀę&YZģÚèûġÌÅ:ĜlçEêĦīLÝı«©H}w8pjńńńńńńńń")]
public class EBin
{
    public const Int32 RET = 4;
    public const Int32 CTRL_ACTOR = 250;
    public const Int32 PARTY_ACTOR = 251;
    public const Int32 PARTYN = 4;
    public const Int32 THIS = 255;
    public const Int32 vcSysList = 5;

    public static ObjList s0;
    public static Obj s1;
    public static Obj objV0;
    public static Int32 SC_COUNTER_SVR = 220;
    public static Int32 MAP_INDEX_SVR = 728;

    public CalcStack calcstack = new CalcStack();

    //private const int ClassSeq = 1;
    //private const int CSeqOfs = 64;
    //private const int WaitMessage = 254;
    //private const int WaitEndReq = 255;
    //private const int VcObjSpec = 4;
    //private const int VcMember = 6;
    //private const int VcConst = 7;
    //private const int Fn = 6;
    //private const int Vt2 = 32;
    //private const int Vt1 = 16;
    //private const int Vt0 = 8;
    //private const int KAtn45 = 10;

    private static Int32 _v0;
    private static Int32 _a0;
    private static Int32 _a1;
    private static Int32 _a2;
    private static Int32 _a3;
    private static Int32 _s2;
    private static Int32 _s3;
    private static Int32 _s5;
    private static Int32 _nextCodeIndex;
    private static CalcStack _s4;
    private static CalcStack _s7;
    private static CalcStack _tempS4;
    private static CalcStack _tempStack = new CalcStack();
    private static Int32 _t0;
    private static Int32 _t2;
    private static Int32 _t3;
    private static Int32 _t4;

    private readonly EventEngine _eventEngine;
    private readonly ETb _eTb;
    private Byte[] _instance;
    private Int32 _instanceVOfs;
    private Boolean _exprLoop;
    private Boolean _objectExists;
    private Boolean _nextLoop;
    private Byte[] _ratanTbl;

    public EBin(EventEngine ee)
    {
        _eventEngine = ee;
        _eTb = _eventEngine.eTb;
        InitializeATanTable();
        _s7 = calcstack;
    }

    private void InitializeATanTable()
    {
        TextAsset textAsset = AssetManager.Load<TextAsset>("EmbeddedAsset/ratan_tbl.bin", false);
        if (textAsset == null)
        {
            //Debug.LogError("InitializeATanTable: cannot load ratan_tble.bin.bytes");
            return;
        }
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);
        _ratanTbl = new Byte[binaryReader.BaseStream.Length];
        binaryReader.Read(_ratanTbl, 0, _ratanTbl.Length);
        binaryReader.Close();
    }

    private UInt16 GetUShortFromATanTable(Int32 offset)
    {
        UInt16 num = _ratanTbl[offset];
        return (UInt16)(num | (UInt16)(_ratanTbl[offset + 1] << 8));
    }

    public Int32 ProcessCode(ObjList objList)
    {
        Int32 result = -1;
        _objectExists = true;
        s0 = objList;
        next1();
        while (_objectExists)
        {
            s1 = s0.obj;
            _a1 = s1.state;
            if (_a1 == EventEngine.stateNew)
            {
                _a0 = EventEngine.stateInit;
                s1.state = (Byte)_a0;
                next0();
                continue;
            }

            _a0 = EventEngine.stateSuspend;
            _s2 = 0;
            if (_a1 == _a0)
            {
                next0();
                continue;
            }

            _nextCodeIndex = s1.ip;
            _a0 = s1.wait;
            if (_nextCodeIndex == _eventEngine.nil)
            {
                next0();
                continue;
            }

            _a2 = 1;
            if (_a0 != 0)
            {
                _a1 = 255;
                if (_a0 != 254)
                {
                    if (_a0 == _a1)
                    {
                        next0();
                    }
                    else
                    {
                        _a0 = s1.wait;
                        _a0--;
                        s1.wait = (Byte)_a0;
                        next0();
                    }
                }
                else
                {
                    _a0 = s1.winnum;
                    if (_a0 == 255)
                    {
                        ad4();
                    }
                    else
                    {
                        Boolean flag = _eTb.MesWinActive(_a0);
                        _a0 = 255;
                        if (flag)
                        {
                            next0();
                        }
                        else
                        {
                            s1.winnum = (Byte)_a0;
                            ad4();
                        }
                    }
                }
                continue;
            }

            _a1 = s1.vofs;
            _eventEngine.gExec = s1;
            _a1 <<= 2;
            _a0 = s1.cid;
            _instance = s1.buffer;
            _instanceVOfs = _a1;
            objV0 = s1;
            _v0 = s1.ip;
            if (_a0 != _a2)
            {
                result = ad3(_a0);
            }
            else
            {
                _a0 = s1.uid;
                _a0 -= 64;
                objV0 = _eventEngine.FindObjByUID(_a0);
                result = ad3(_a0);
            }
            objV0 = null;
        }
        return result;
    }

    private void adFin()
    {
        _nextLoop = false;
        _objectExists = false;
    }

    public Int32 ad3(Int32 arg0)
    {
        _a0 = _eventEngine.gMode;
        _eventEngine.gCur = objV0;
        _a1 = 2;
        Int32 result;
        if (_a0 != _a1)
        {
            result = next(_a0);
        }
        else
        {
            _eventEngine.ProcessCodeExt(s1);
            result = next(_a0);
        }
        return result;
    }

    private void ad4()
    {
        _a0 = 0;
        s1.wait = (Byte)_a0;
        next0();
    }

    public Int32 next(Int32 arg0)
    {
        _nextLoop = true;
        while (_nextLoop)
        {
            if (_s2 == 0)
            {
                _a0 = s1.getByteIP();
                if (s1.sid == 1 || s1.sid == 0)
                {
                }
                Int32 num = _a0 << 2;
                _a2 = num - 440;
                if (_a2 >= 0)
                {
                    commandDefault2();
                }
                else
                {
                    s1.ip++;
                    jumpToCommand(_a0);
                    if (FF9StateSystem.Settings.IsFastTrophyMode)
                    {
                        EMinigame.DigUpMadianRingCheating();
                    }
                }
            }
            else
            {
                adfr();
            }
        }
        return _v0;
    }

    public void adfr()
    {
        _v0 = _s2;
        if (_s2 == 4)
        {
            adFin();
        }
        else if (_s2 == 5)
        {
            adFin();
        }
        else
        {
            _a0 = 3;
            if (_s2 == _a0)
            {
                adFin();
            }
            else
            {
                _a0 = 7;
                if (_s2 == _a0)
                {
                    adFin();
                }
                else
                {
                    _a0 = 8;
                    if (_s2 == _a0)
                    {
                        adFin();
                    }
                    else
                    {
                        _a0 = 6;
                        if (_s2 != _a0)
                        {
                            _a0 = 2;
                            if (_s2 == _a0)
                            {
                                next1();
                            }
                            else
                            {
                                next0();
                            }
                        }
                        else
                        {
                            _a0 = 2;
                            _eventEngine.gStopObj = s0;
                            adFin();
                        }
                    }
                }
            }
        }
    }

    public void next0()
    {
        if (s0 != null)
        {
            getVarManually(6357);
            s0 = s0.next;
        }
        next1();
    }

    public void next1()
    {
        _v0 = 0;
        if (s0 != null)
        {
            _nextLoop = false;
        }
        else
        {
            _nextLoop = false;
            _objectExists = false;
        }
    }

    public Int32 expr()
    {
        _s7 = calcstack;
        _tempS4 = _s4;
        _s4 = _eventEngine.gCP;
        _s7.emptyCalcStack();
        _exprLoop = true;
        while (_exprLoop)
        {
            SByte b = (SByte)s1.getByteIP();
            if (s1.sid == 11)
            {
            }
            if (s1.sid != 3 || s1.ip != 110)
            {
                if (FF9StateSystem.Settings.IsFastTrophyMode)
                {
                    if (FF9StateSystem.Common.FF9.fldMapNo == 2801 && s1.sid == 11 && s1.ip == 3834)
                    {
                        setVarManually(11989, 8);
                    }
                    if (FF9StateSystem.Common.FF9.fldMapNo == 1900 && s1.sid == 0 && s1.ip == 4138)
                    {
                        setVarManually(8198869, 8);
                    }
                }
            }
            if (FF9StateSystem.Common.FF9.fldMapNo == 705 && s1.sid == 3 && s1.ip == 541)
            {
                s1.ip += 7;
                return 0;
            }
            EMinigame.ChanbaraBonusPoints(s1, (Original::EBin)(System.Object)this);
            EMinigame.SetViviSpeed(s1, (Original::EBin)(System.Object)this);
            _a2 = b << 2;
            if (b < 0)
            {
                s1.ip++;
                _v0 = expr_varSpec(b);
                _s7.push(_v0);
            }
            else
            {
                s1.ip++;
                expr_jumpToSubCommand(b);
            }
        }
        return 0;
    }

    private Int32 expr_varSpec(Int32 arg0)
    {
        _v0 = (arg0 & 3);
        _v0 <<= 26;
        _a1 = (arg0 & 28);
        _a1 <<= 27;
        _v0 |= _a1;
        _a1 = s1.getByteIP();
        arg0 &= 32;
        s1.ip++;
        if (arg0 != 0)
        {
            _v0 |= _a1;
            _a1 = s1.getByteIP();
            s1.ip++;
            _a1 <<= 8;
        }
        _v0 |= _a1;
        return _v0;
    }

    public Int32 setVarManually(Int32 var, Int32 value)
    {
        Int32 num = var & 255;
        Int32 num2 = num & 3;
        num2 <<= 26;
        Int32 num3 = num & 28;
        num3 <<= 27;
        num2 |= num3;
        Int32 num4 = (var & 65280) >> 8;
        num &= 32;
        if (num != 0)
        {
            num2 |= num4;
            num4 = (var & 16711680) >> 16;
            num4 <<= 8;
        }
        num2 |= num4;
        _s7.push(num2);
        putvi(value);
        num3 = encodeTypeAndVarClass(7);
        num2 |= num3;
        _s7.push(num2);

        return num2;
    }

    public Int32 getVarManually(Int32 var)
    {
        CalcStack calcStack = _s7;
        _s7 = _tempStack;
        _s7.emptyCalcStack();
        Int32 num = var & 255;
        Int32 num2 = num & 3;
        num2 <<= 26;
        Int32 num3 = num & 28;
        num3 <<= 27;
        num2 |= num3;
        Int32 num4 = (var & 65280) >> 8;
        num &= 32;
        if (num != 0)
        {
            num2 |= num4;
            num4 = (var & 16711680) >> 16;
            num4 <<= 8;
        }
        num2 |= num4;
        _s7.push(num2);
        Int32 result = getvi();
        _s7 = calcStack;
        return result;
    }

    private void expr_jumpToSubCommand(Int32 arg0)
    {
        if (arg0 >= 0 && arg0 <= 127)
        {
            switch (arg0)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 8:
                case 9:
                case 10:
                case 11:
                case 15:
                case 46:
                case 67:
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 78:
                case 82:
                case 83:
                case 90:
                case 91:
                case 92:
                case 100:
                case 101:
                case 103:
                case 104:
                case 105:
                case 106:
                case 108:
                case 110:
                case 111:
                case 112:
                case 113:
                case 123:
                case 124:
                    _eventEngine.gCP = _s7;
                    _v0 = _eventEngine.DoCalcOperationExt(arg0);
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 4:
                    _v0 = getvi();
                    _t3 = _v0;
                    _s7.advanceTopOfStack();
                    _a0 = _v0 + 1;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 5:
                    _v0 = getvi();
                    _t3 = _v0;
                    _s7.advanceTopOfStack();
                    _a0 = _v0 - 1;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 6:
                    _v0 = getvi();
                    _t3 = _v0 + 1;
                    _s7.advanceTopOfStack();
                    _a0 = _t3;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 7:
                    _v0 = getvi();
                    _t3 = _v0 - 1;
                    _s7.advanceTopOfStack();
                    _a0 = _t3;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 12:
                    expr_ad0();
                    break;
                case 13:
                    _v0 = getvi();
                    _v0 = 0 - _v0;
                    expr_ad0();
                    break;
                case 14:
                    _v0 = getvi();
                    _v0 = 0 < _v0 ? 1 : 0;
                    _v0 ^= 1;
                    expr_ad0();
                    break;
                case 16:
                    _v0 = getvi();
                    _v0 = ~(0 | _v0);
                    expr_ad0();
                    break;
                case 17:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 *= _t3;
                    expr_ad0();
                    break;
                case 18:
                    _t3 = getvi();
                    _v0 = getvi();
                    if (_t3 == 0)
                    {
                        expr_adZ();
                    }
                    else
                    {
                        _v0 /= _t3;
                        expr_ad0();
                    }
                    break;
                case 19:
                    _t3 = getvi();
                    _v0 = getvi();
                    if (_t3 == 0)
                    {
                        expr_adZ();
                    }
                    else
                    {
                        _v0 %= _t3;
                        expr_ad0();
                    }
                    break;
                case 20:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 += _t3;
                    expr_ad0();
                    break;
                case 21:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 -= _t3;
                    expr_ad0();
                    break;
                case 22:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 <<= _t3;
                    expr_ad0();
                    break;
                case 23:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 >>= _t3;
                    expr_ad0();
                    break;
                case 24:
                    _t3 = getvi();
                    _v0 = getvi();
                    if (_eventEngine.gCur.uid == 13 && _t3 == -300)
                    {
                        _t3 = -250;
                    }
                    _v0 = _v0 < _t3 ? 1 : 0;
                    expr_ad0();
                    break;
                case 25:
                    _t3 = getvi();
                    _v0 = getvi();
                    if (FF9StateSystem.Common.FF9.fldMapNo == 657 && _eventEngine.gCur.sid == 17 && (_eventEngine.gCur.ip == 1413 || _eventEngine.gCur.ip == 1542 || _eventEngine.gCur.ip == 1666 || _eventEngine.gCur.ip == 1795 || _eventEngine.gCur.ip == 2172 || _eventEngine.gCur.ip == 2301 || _eventEngine.gCur.ip == 1919 || _eventEngine.gCur.ip == 2048 || _eventEngine.gCur.ip == 2425 || _eventEngine.gCur.ip == 2554 || _eventEngine.gCur.ip == 2683 || _eventEngine.gCur.ip == 2812 || _eventEngine.gCur.ip == 2941))
                    {
                        _v0 = _t3 <= _v0 ? 1 : 0;
                    }
                    else if (_t3 < _v0)
                    {
                        _v0 = 1;
                    }
                    else
                    {
                        _v0 = 0;
                    }
                    expr_ad0();
                    break;
                case 26:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 = _t3 < _v0 ? 1 : 0;
                    _v0 ^= 1;
                    expr_ad0();
                    break;
                case 27:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 = _v0 < _t3 ? 1 : 0;
                    _v0 ^= 1;
                    expr_ad0();
                    break;
                case 28:
                case 29:
                case 30:
                case 31:
                case 34:
                case 35:
                case 84:
                case 85:
                case 86:
                case 87:
                    if (s1.sid != 0 || s1.ip == 320)
                    {
                    }
                    _eventEngine.gCP = _s7;
                    _v0 = _eventEngine.OperatorExtract(arg0);
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 32:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 ^= _t3;
                    _v0 = Mathf.Abs(_v0) < 1 ? 1 : 0;
                    expr_ad0();
                    break;
                case 33:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 ^= _t3;
                    _v0 = 0 < Mathf.Abs(_v0) ? 1 : 0;
                    expr_ad0();
                    break;
                case 36:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 &= _t3;
                    expr_ad0();
                    break;
                case 37:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 ^= _t3;
                    expr_ad0();
                    break;
                case 38:
                    _t3 = getvi();
                    _v0 = getvi();
                    _v0 |= _t3;
                    expr_ad0();
                    break;
                case 39:
                    _v0 = getvi();
                    _s7.retreatTopOfStack();
                    if (_v0 == 0)
                    {
                        expr_ad0();
                    }
                    else
                    {
                        _s7.advanceTopOfStack();
                        _v0 = getvi();
                        _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                        expr_ad0();
                    }
                    break;
                case 40:
                    _v0 = getvi();
                    _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                    _s7.retreatTopOfStack();
                    if (_v0 != 0)
                    {
                        expr_ad0();
                    }
                    else
                    {
                        _s7.advanceTopOfStack();
                        _v0 = getvi();
                        _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                        expr_ad0();
                    }
                    break;
                case 41:
                    _a0 = s1.getByteIP();
                    s1.ip++;
                    _a1 = encodeTypeAndVarClass(6);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 42:
                    if (s1.sid != 0 || s1.ip == 321)
                    {
                    }
                    _eventEngine.gCP = _s7;
                    _v0 = _eventEngine.OperatorCount();
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 43:
                    _eventEngine.gCP = _s7;
                    _v0 = _eventEngine.OperatorPick();
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 44:
                    _v0 = getvi();
                    _a0 = _v0;
                    _t3 = _v0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 45:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 64:
                case 65:
                case 66:
                    _eventEngine.gCP = _s7;
                    if (s1.sid == 0 && s1.ip == 411)
                    {
                        //Debug.Log("Debug @all");
                    }
                    _v0 = _eventEngine.OperatorAll(arg0);
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 47:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = _v0 * _t3;
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 48:
                    _t3 = getvi();
                    _v0 = getvi();
                    _s7.advanceTopOfStack();
                    if (_t3 == 0)
                    {
                        expr_adZ();
                    }
                    else
                    {
                        _a0 = _v0 / _t3;
                        _t3 = _a0;
                        putvi(_a0);
                        _v0 = _t3;
                        expr_ad0();
                    }
                    break;
                case 49:
                    _t3 = getvi();
                    _v0 = getvi();
                    _s7.advanceTopOfStack();
                    if (_t3 == 0)
                    {
                        expr_adZ();
                    }
                    else
                    {
                        _a0 = _v0 % _t3;
                        _t3 = _a0;
                        putvi(_a0);
                        _v0 = _t3;
                        expr_ad0();
                    }
                    break;
                case 50:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = _v0 + _t3;
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 51:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = _v0 - _t3;
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 52:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = _v0 << _t3;
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 53:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = _v0 >> _t3;
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 61:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = (_v0 & _t3);
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 62:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = (_v0 ^ _t3);
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 63:
                    _t3 = getvi();
                    _v0 = getvi();
                    _a0 = (_v0 | _t3);
                    _s7.advanceTopOfStack();
                    _t3 = _a0;
                    putvi(_a0);
                    _v0 = _t3;
                    expr_ad0();
                    break;
                case 77:
                    _eventEngine.gCP = _s7;
                    _v0 = _eventEngine.OperatorSelect();
                    _s7 = _eventEngine.gCP;
                    expr_ad0();
                    break;
                case 79:
                    _t3 = (Int32)ETb.KeyOn();
                    _v0 = getvi();
                    _v0 &= _t3;
                    if (s1.sid == 5)
                    {
                    }
                    _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                    expr_ad0();
                    break;
                case 80:
                    _a0 = getvi();
                    _v0 = ff9.rsin(_a0);
                    expr_ad0();
                    break;
                case 81:
                    _a0 = getvi();
                    _v0 = ff9.rcos(_a0);
                    expr_ad0();
                    break;
                case 88:
                    _t3 = (Int32)ETb.KeyOff();
                    _v0 = getvi();
                    _v0 &= _t3;
                    _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                    expr_ad0();
                    break;
                case 89:
                    _t3 = (Int32)_eTb.PadReadE();
                    _v0 = getvi();
                    _v0 &= _t3;
                    _v0 = ((0 >= Mathf.Abs(_v0)) ? 0 : 1);
                    expr_ad0();
                    break;
                case 93:
                {
                    _t3 = getvi();
                    _v0 = getvi();
                    Obj gCur = _eventEngine.gCur;
                    Actor actor = (Actor)gCur;
                    if (actor.fieldMapActorController == null)
                    {
                    }
                    Single num = actor.pos[0];
                    Single num2 = actor.pos[2];
                    num = _v0 - num;
                    num2 = _t3 - num2;
                    Single floatAngle = angleAsm(num, num2);
                    Int32 num3 = ConvertFloatAngleToFixedPoint(floatAngle);
                    _v0 = 0;
                    _v0 = num3;
                    _v0 <<= 20;
                    _v0 >>= 24;
                    expr_ad0();
                    break;
                }
                case 94:
                {
                    _t3 = getvi();
                    _v0 = getvi();
                    Obj gCur = _eventEngine.gCur;
                    Actor actor = (Actor)gCur;
                    Single num4 = actor.pos[0];
                    Single num5 = actor.pos[2];
                    num4 = _v0 - num4;
                    num5 = _t3 - num5;
                    _a1 = 0;
                    _v0 = (Int32)distance(num4, _a1, num5);
                    expr_ad0();
                    break;
                }
                case 95:
                {
                    _a0 = s1.getByteIP();
                    s1.ip++;
                    Obj objUID = _eventEngine.GetObjUID(_a0);
                    _v0 = objUID.uid;
                    expr_ad0();
                    break;
                }
                case 96:
                {
                    _v0 = getvi();
                    Obj objUID2 = _eventEngine.GetObjUID(_v0);
                    Single num6 = ((PosObj)objUID2).pos[0];
                    Single num7 = ((PosObj)objUID2).pos[2];
                    Single num8 = ((PosObj)_eventEngine.gCur).pos[0];
                    Single num9 = ((PosObj)_eventEngine.gCur).pos[2];
                    Single floatAngle = angleAsm(num6 - num8, num7 - num9);
                    Int32 num3 = ConvertFloatAngleToFixedPoint(floatAngle);
                    _v0 = num3 >> 4;
                    expr_ad0();
                    break;
                }
                case 97:
                {
                    _v0 = getvi();
                    Obj objUID2 = _eventEngine.GetObjUID(_v0);
                    Obj gCur = _eventEngine.gCur;
                    Actor actor = (Actor)gCur;
                    _a0 = 524288000;
                    Single num4 = ((Actor)objUID2).pos[0] - actor.pos[0];
                    Single num5 = ((Actor)objUID2).pos[2] - actor.pos[2];
                    _a1 = 0;
                    _v0 = (Int32)distance(num4, _a1, num5);
                    expr_ad0();
                    break;
                }
                case 98:
                    _v0 = getvi();
                    _a0 = _v0 << 4;
                    _v0 = ff9.rsin(_a0);
                    expr_ad0();
                    break;
                case 99:
                    _v0 = getvi();
                    _a0 = _v0 << 4;
                    _v0 = ff9.rcos(_a0);
                    expr_ad0();
                    break;
                case 102:
                {
                    _t3 = getvi();
                    _a0 = getvi();
                    _a1 = _t3;
                    Single floatAngle = angleAsm(_a0, _a1);
                    Int32 num3 = ConvertFloatAngleToFixedPoint(floatAngle);
                    _v0 = num3 >> 4;
                    expr_ad0();
                    break;
                }
                case 107:
                    _a0 = getvi();
                    _v0 = _eventEngine.partychk(_a0) ? 1 : 0;
                    expr_ad0();
                    break;
                case 109:
                    _a0 = getvi();
                    _v0 = _eventEngine.partyadd(_a0) ? 1 : 0;
                    expr_ad0();
                    break;
                case 120:
                    _a0 = s1.getByteIP();
                    _a1 = s1.getByteIP(1);
                    s1.ip += 2;
                    _a0 <<= 8;
                    _a0 |= _a1;
                    _a1 = encodeTypeAndVarClass(4);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 121:
                    _a0 = s1.getByteIP();
                    s1.ip++;
                    _a1 = encodeTypeAndVarClass(5);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 122:
                    _a0 = s1.getByteIP();
                    s1.ip++;
                    _v0 = _eventEngine.GetSysvar(_a0);
                    _a0 = 67108863;
                    _a0 = (_v0 & _a0);
                    _a1 = encodeTypeAndVarClass(7);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 125:
                    _a0 = s1.getShortIP();
                    s1.ip += 2;
                    _a1 = encodeTypeAndVarClass(7);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 126:
                    _a0 = s1.getIntIP();
                    s1.ip += 4;
                    _a0 &= 67108863;
                    _a1 = encodeTypeAndVarClass(7);
                    _a0 |= _a1;
                    _s7.push(_a0);
                    break;
                case 127:
                    _eventEngine.gCP = _s7;
                    _s4 = _tempS4;
                    _exprLoop = false;
                    break;
            }
        }
    }

    private static Int32 ConvertFloatAngleToFixedPoint(Single floatAngle)
    {
        Single f = (Single)(floatAngle / 360.0 * 4096.0);
        Int32 int1 = Mathf.FloorToInt(f);
        Int32 int2 = Mathf.CeilToInt(f);
        Int32 int3 = Mathf.RoundToInt(f);
        if (int3 == int2)
            return int2;
        if (int3 == int1)
            return int1;
        return -1;
    }

    private void expr_ad0()
    {
        _a1 = encodeTypeAndVarClass(7);
        _v0 |= _a1;
        _s7.push(_v0);
    }

    private void expr_adZ()
    {
        expr_ad0();
    }

    public Int32 bra()
    {
        Int16 shortIP = s1.getShortIP();
        s1.ip += 2;
        s1.ip += shortIP;
        return 0;
    }

    public Int32 beq()
    {
        _v0 = getvi();
        if (_v0 != 0)
        {
            s1.ip += 2;
        }
        else
        {
            Int32 uShortIP = s1.getUShortIP();
            s1.ip += 2;
            s1.ip += uShortIP;
        }
        return 0;
    }

    public Int32 bne()
    {
        _v0 = getvi();
        if (_v0 == 0)
        {
            s1.ip += 2;
        }
        else
        {
            bra();
        }
        return 0;
    }

    public Int32 wait()
    {
        _s5 = s1.getByteIP();
        s1.ip++;
        _v0 = getv1i();
        if (FF9StateSystem.Common.FF9.fldMapNo == 3011)
        {
            String symbol = Localization.GetSymbol();
            if (symbol != "US" && symbol != "JP")
            {
                if (_v0 == 82)
                {
                    _v0 = 102;
                }
                else if (_v0 == 50)
                {
                    _v0 = 90;
                }
            }
        }
        else if (FF9StateSystem.Common.FF9.fldMapNo == 3009)
        {
            String symbol2 = Localization.GetSymbol();
            if (symbol2 != "US" && symbol2 != "JP" && s1.uid == 17 && _v0 == 15)
            {
                _v0 = 20;
            }
        }
        _a0 = _v0 - 254;
        if (_v0 != 0)
        {
            _v0--;
            if (_a0 > 0)
            {
                _v0 = 253;
            }
            s1.wait = (Byte)_v0;
            _s2 = 1;
        }
        return 0;
    }

    private void ad2()
    {
        _t3 = s1.getByteIP(1);
        _t4 = (SByte)s1.getByteIP(2);
        _t4 <<= 8;
        _v0 = getvi();
        _v0 -= _t3;
        _v0 -= _t4;
        _a0 = _v0 - _t2;
        if (_v0 < 0)
        {
            ad5();
        }
        else
        {
            _v0 <<= 1;
            if (_a0 >= 0)
            {
                ad5();
            }
            else
            {
                _a0 = _nextCodeIndex + _v0;
                _a1 = s1.getByteIP(_v0 + 5);
                _a2 = s1.getByteIP(_v0 + 6);
                s1.ip += _a1;
                s1.ip += _a2 << 8;
            }
        }
    }

    public void ad5()
    {
        _a0 = s1.getByteIP(3);
        _a1 = s1.getByteIP(4);
        _a1 = (_a1 << 8 | _a0);
        s1.ip += _a1;
    }

    public Int32 commandDefault()
    {
        s1.ip--;
        commandDefault2();
        return 0;
    }

    public Int32 commandDefault2()
    {
        Int32 ip = s1.ip;
        _v0 = _eventEngine.DoEventCode();
        _s2 = _v0;
        _a0 = _eventEngine.gArgUsed;
        _nextCodeIndex = s1.ip;
        s1.ip = ip;
        _a0 = ((0 >= _a0) ? 0 : 1);
        _a0 ^= 1;
        _nextCodeIndex -= _a0;
        s1.ip = _nextCodeIndex;
        return 0;
    }

    public void ad13()
    {
        if (_t2 > 0)
        {
            _t2--;
            _t4 = s1.getByteIP(1 + _a0);
            _t3 = s1.getByteIP(0 + _a0);
            Int32 num = _t3 | _t4 << 8;
            num -= _v0;
            _a0 += 4;
            if (num == 0)
            {
                _t4 = s1.getByteIP(-1 + _a0);
                _t3 = s1.getByteIP(-2 + _a0);
                _t3 |= _t4 << 8;
                s1.ip += _t3;
                s1.ip += 3;
            }
            else
            {
                ad13();
            }
        }
        else
        {
            _t2--;
            _t4 = s1.getByteIP(2);
            _t3 = s1.getByteIP(1);
            _t3 |= _t4 << 8;
            s1.ip += _t3;
            s1.ip += 3;
        }
    }

    public void ad21()
    {
        s0 = _eventEngine.DisposeObj(s1);
        _s2 = 2;
    }

    public Int32 jumpToCommand(Int32 arg0)
    {
        if (arg0 >= 0 && arg0 <= 109)
        {
            switch (arg0)
            {
                case 1:
                    bra();
                    return 0;
                case 2:
                    beq();
                    return 0;
                case 3:
                    bne();
                    return 0;
                case 4:
                    _eventEngine.Return(s1);
                    adfr();
                    return 0;
                case 5:
                    expr();
                    return 0;
                case 6:
                    _t2 = s1.getByteIP();
                    _v0 = getvi();
                    _v0 &= 65535;
                    _a0 = 3;
                    ad13();
                    return 0;
                case 11:
                    _t2 = s1.getByteIP();
                    ad2();
                    return 0;
                case 13:
                    _t2 = s1.getShortIP();
                    s1.ip++;
                    ad2();
                    return 0;
                default:
                    switch (arg0)
                    {
                        case 48:
                            return 0;
                        case 49:
                            return 0;
                        case 50:
                            _s5 = s1.getByteIP();
                            s1.ip++;
                            _a0 = getv1i();
                            _a1 = getv1i();
                            return 0;
                        default:
                            if (arg0 == 108)
                            {
                                return 0;
                            }
                            if (arg0 == 109)
                            {
                                return 0;
                            }
                            if (arg0 == 28)
                            {
                                _a0 = s1.getByteIP(1);
                                _a1 = 255;
                                s1.ip += 2;
                                if (_a0 == _a1)
                                {
                                    ad21();
                                }
                                else
                                {
                                    Obj objUID = _eventEngine.GetObjUID(_a0);
                                    if (s1 == objUID)
                                    {
                                        ad21();
                                    }
                                    else
                                    {
                                        _eventEngine.DisposeObj(objUID);
                                    }
                                }
                                return 0;
                            }
                            if (arg0 != 34)
                            {
                                commandDefault();
                                return 0;
                            }
                            wait();
                            return 0;
                    }
            }
        }
        Debug.Log("EBin.jumpToCommand INVALID command " + arg0);
        return -1;
    }

    public Single angleAsm(Single deltaX, Single deltaZ)
    {
        Int32 num1 = (Int32)deltaX;
        Int32 num2 = (Int32)deltaZ;
        if (num1 == 0 && num2 == 0)
            return 0.0f;
        Int32 num3 = num2 << 10;
        Int32 num4 = num1 << 10;
        Int32 num5;
        if (num2 >= 0)
        {
            Int32 num6 = num1 - num2;
            num5 = num1 >= 0 ? (num6 >= 0 ? -1024 - (Int32)this.GetUShortFromATanTable(num3 / num1 << 1) : (Int32)this.GetUShortFromATanTable(num4 / num2 << 1) - 2048) : (-num1 - num2 < 0 ? 2048 - (Int32)this.GetUShortFromATanTable(-(num4 / num2 << 1)) : 1024 + (Int32)this.GetUShortFromATanTable(-(num3 / num1 << 1)));
        }
        else
        {
            Int32 num6 = num1 - num2;
            if (num1 >= 0)
            {
                Int32 num7 = -num2;
                num5 = num1 - num7 < 0 ? -this.GetUShortFromATanTable(-(num4 / num2 << 1)) : (Int32)this.GetUShortFromATanTable(-(num3 / num1 << 1)) - 1024;
            }
            else
                num5 = num6 < 0 ? 1024 - (Int32)this.GetUShortFromATanTable(num3 / num1 << 1) : (Int32)this.GetUShortFromATanTable(num4 / num2 << 1);
        }
        return EventEngineUtils.ConvertFixedPointAngleToDegree((Int16)num5);
    }

    private static Single ConvertFixedPointAngleToDegree(Int16 fixedPointAngle)
    {
        return (Single)((fixedPointAngle >> 4) / 256.0 * 360.0);
    }

    public Int32 CollisionAngle(PosObj po, PosObj pot, Single myrot)
    {
        Single num = po.pos[0];
        Single num2 = pot.pos[0];
        Single num3 = po.pos[2];
        Single num4 = pot.pos[2];
        Single deltaX = num2 - num;
        Single deltaZ = num4 - num3;
        Single num5 = angleAsm(deltaX, deltaZ);
        num = myrot - num5;
        if (num > 180f)
        {
            num -= 360f;
        }
        else if (num < -180f)
        {
            num += 360f;
        }
        return ConvertFloatAngleToFixedPoint(num);
    }

    public Int32 getvi()
    {
        _s7.pop(ref _t0);
        _a2 = getTypeAndVarClass(_t0);
        _a0 = getVarClass(_t0);
        switch ((VariableSource)_a0)
        {
            case VariableSource.Global:
                _a1 = (_t0 & 65535);
                return getvsub(FF9StateSystem.EventState.gEventGlobal, _a1, _a2, 0);
            case VariableSource.Map:
                _a1 = (_t0 & 65535);
                return getvsub(_eventEngine.GetMapVar(), _a1, _a2, 0);
            case VariableSource.Instance:
                _a1 = (_t0 & 65535);
                return getvsub(_instance, _a1, _a2, _instanceVOfs);
            case VariableSource.Object:
            {
                _a0 = _t0 >> 8;
                _a0 &= 255;
                Obj objUID = _eventEngine.GetObjUID(_a0);
                _a1 = (_t0 & 255);
                _v0 = getvobj(objUID, _a1);
                return _v0;
            }
            case VariableSource.System:
                _a0 = (_t0 & 255);
                _v0 = _eventEngine.GetSysList(_a0);
                return _v0;
            case VariableSource.Member:
                _t0 <<= 6;
                _a1 = _t0 >> 6;
                _v0 = getvobj(_eventEngine.gMemberTarget, _a1);
                return _v0;
            case VariableSource.Int26:
                _t0 <<= 6;
                _v0 = _t0 >> 6;
                return _v0;
        }
        return 0;
    }

    private Int32 getvobj(Obj obj, Int32 type)
    {
        Int32 result;
        switch (type)
        {
            case 0:
            {
                if (obj.cid != 4)
                {
                    return 0;
                }
                result = CastFloatToIntWithChecking(((PosObj)obj).pos[0]);
                WMActor wmActor = ((Actor)obj).wmActor;
                if (wmActor != null)
                {
                }
                break;
            }
            case 1:
            {
                if (obj.cid != 4)
                {
                    return 0;
                }
                result = -1 * CastFloatToIntWithChecking(((PosObj)obj).pos[1]);
                WMActor wmActor = ((Actor)obj).wmActor;
                if (wmActor != null)
                {
                }
                break;
            }
            case 2:
            {
                if (obj.cid != 4)
                {
                    return 0;
                }
                result = CastFloatToIntWithChecking(((PosObj)obj).pos[2]);
                WMActor wmActor = ((Actor)obj).wmActor;
                if (wmActor != null)
                {
                }
                break;
            }
            case 3:
            {
                Single floatAngle = 0f;
                if (_eventEngine.gMode == 1)
                {
                    floatAngle = ((Actor)obj).rotAngle[1];
                }
                else if (_eventEngine.gMode == 3)
                {
                    floatAngle = ((Actor)obj).wmActor.rot1;
                }
                Int32 num = ConvertFloatAngleToFixedPoint(floatAngle);
                Int32 num2 = num >> 4 & 255;
                result = num2;
                break;
            }
            case 4:
                result = obj.flags;
                break;
            case 5:
                result = obj.uid;
                break;
            case 6:
                result = obj.level;
                break;
            case 7:
                result = ((PosObj)obj).animFrame;
                break;
            default:
                result = PersistenSingleton<EventEngine>.Instance.GetBattleCharData(obj, type);
                break;
        }
        return result;
    }

    private static Int32 CastFloatToIntWithChecking(Single floatValue)
    {
        Int32 int1 = Mathf.FloorToInt(floatValue);
        Int32 int2 = Mathf.CeilToInt(floatValue);
        Int32 int3 = Mathf.RoundToInt(floatValue);
        if (int3 == int2)
            return int2;
        if (int3 == int1)
            return int1;
        return -1;
    }

    private Single distance(Single x, Single y, Single z)
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    public Int32 getvsub(Byte[] buffer, Int32 ofs, Int32 type, Int32 bufferOffset = 0)
    {
        _v0 = (type & 56) >> 3;
        switch ((VariableType)_v0)
        {
            case VariableType.SBit:
            case VariableType.Bit:
                _v0 = ofs >> 3; // 5
                _a0 = (SByte)buffer[_v0 + bufferOffset];
                _v0 = (ofs & 7); // 3
                _a0 >>= _v0;
                _v0 = (_a0 & 1);
                return _v0;
            case VariableType.Int24:
            case VariableType.UInt24:
                _v0 = (SByte)buffer[ofs + 2 + bufferOffset];
                _a1 = buffer[ofs + 1 + bufferOffset];
                _v0 = (_v0 << 8 | _a1);
                _a1 = buffer[ofs + bufferOffset];
                _v0 <<= 8;
                _v0 |= _a1;
                return _v0;
            case VariableType.SByte:
                _v0 = (SByte)buffer[ofs + bufferOffset];
                return _v0;
            case VariableType.Byte:
                _v0 = buffer[ofs + bufferOffset];
                return _v0;
            case VariableType.Int16:
                _v0 = (SByte)buffer[ofs + 1 + bufferOffset];
                _a0 = buffer[ofs + bufferOffset];
                _v0 <<= 8;
                _v0 |= _a0;
                return _v0;
            case VariableType.UInt16:
                _v0 = buffer[ofs + 1 + bufferOffset];
                _a0 = buffer[ofs + bufferOffset];
                _v0 <<= 8;
                _v0 |= _a0;
                return _v0;
            default:
                return 0;
        }
    }

    public Int32 getv1i()
    {
        _v0 = (_s5 & 1);
        _s5 >>= 1;
        if (_v0 != 0)
        {
            expr();
            _v0 = getvi();
            return _v0;
        }
        _v0 = s1.getByteIP();
        s1.ip++;
        return _v0;
    }

    public Int32 putvi(Int32 arg0)
    {
        _s7.pop(ref _t0);
        _a3 = arg0;
        _a2 = _t0 >> 26;
        switch ((VariableSource)(_a2 & 7))
        {
            case VariableSource.Global:
                _a1 = (_t0 & 65535);
                putvsub(FF9StateSystem.EventState.gEventGlobal, _a1, _a2, _a3, 0);
                break;
            case VariableSource.Map:
                _a1 = (_t0 & 65535);
                putvsub(_eventEngine.GetMapVar(), _a1, _a2, _a3, 0);
                break;
            case VariableSource.Instance:
                _a1 = (_t0 & 65535);
                putvsub(_instance, _a1, _a2, _a3, _instanceVOfs);
                break;
            case VariableSource.System:
                _a0 = (_t0 & 255);
                _a1 = _a3;
                _eventEngine.SetSysList(_a0, _a1);
                break;
            case VariableSource.Member:
                _a1 = (_t0 & 255);
                _a2 = _a3;
                _eventEngine.putvobj(_eventEngine.gMemberTarget, _a1, _a2);
                break;
        }
        return 0;
    }

    public Int32 putvsub(Byte[] buffer, Int32 ofs, Int32 type, Int32 value, Int32 bufferOffset = 0)
    {
        _v0 = (type & 56) >> 3;
        switch ((VariableType)_v0)
        {
            case VariableType.SBit:
            case VariableType.Bit:
            {
                _v0 = (ofs & 7);
                Int32 num = ofs >> 3;
                _a1 = (SByte)buffer[num + bufferOffset];
                _a2 = 1;
                _a2 <<= _v0;
                if (value == 0)
                {
                    _a2 ^= 255;
                    _a1 &= _a2;
                    buffer[num + bufferOffset] = (Byte)_a1;
                }
                else
                {
                    _a1 |= _a2;
                    buffer[num + bufferOffset] = (Byte)_a1;
                }
                break;
            }
            case VariableType.Int24:
            case VariableType.UInt24:
                if (EventHUD.CurrentHUD == MinigameHUD.JumpingRope && Configuration.Hacks.Enabled && (ofs == 43 || ofs == 59))
                    value = value - 1 + Configuration.Hacks.RopeJumpingIncrement;

                buffer[ofs + bufferOffset] = (Byte)(value & 255);
                buffer[ofs + 1 + bufferOffset] = (Byte)((value & 65280) >> 8);
                buffer[ofs + 2 + bufferOffset] = (Byte)((value & 16711680) >> 16);
                break;
            case VariableType.SByte:
            case VariableType.Byte:
                buffer[ofs + bufferOffset] = (Byte)_a3;
                break;
            case VariableType.Int16:
            case VariableType.UInt16:
                buffer[ofs + bufferOffset] = (Byte)(value & 255);
                buffer[ofs + 1 + bufferOffset] = (Byte)((value & 65280) >> 8);
                break;
        }
        return 0;
    }

    public void SetVariableSpec(ref Int32 arg0)
    {
        _nextCodeIndex = s1.getByteIP();
        arg0 = s1.getByteIP();
    }

    public Int32 CalcExpr()
    {
        Obj obj = s1;
        Int32 num = _s3;
        Int32 num2 = _nextCodeIndex;
        CalcStack calcStack = _s7;
        s1 = _eventEngine.gExec;
        expr();
        s1 = obj;
        _s3 = num;
        _nextCodeIndex = num2;
        _s7 = calcStack;
        return 0;
    }

    public Int32 getv()
    {
        CalcStack calcStack = _s7;
        _s7 = _eventEngine.gCP;
        _v0 = getvi();
        _s7 = calcStack;
        return _v0;
    }

    public Int32 putv(Int32 a)
    {
        CalcStack calcStack = _s7;
        _s7 = _eventEngine.gCP;
        _v0 = putvi(a);
        _s7 = calcStack;
        return _v0;
    }

    private Int32 getVarClass(Int32 value)
    {
        Int32 typeAndVarClass = getTypeAndVarClass(value);
        return typeAndVarClass & 7;
    }

    private Int32 getTypeAndVarClass(Int32 value)
    {
        return value >> 26;
    }

    private Int32 encodeTypeAndVarClass(Int32 typeAndClass)
    {
        return typeAndClass << 10 << 16;
    }

    public enum event_code_binary
    {
        NOP,
        rsv01,
        rsv02,
        rsv03,
        rsv04,
        EXPR,
        rsv06,
        NEW,
        NEW2,
        NEW3,
        pad0a,
        rsv0b,
        rsv0c,
        rsv0d,
        pad0e,
        pad0f,
        REQ,
        pad11,
        REQSW,
        pad13,
        REQEW,
        pad15,
        REPLY,
        pad17,
        REPLYSW,
        pad19,
        REPLYEW,
        SONGFLAG,
        DELETE,
        POS,
        BGVPORT,
        MES,
        MESN,
        CLOSE,
        WAIT,
        MOVE,
        MOVA,
        CLRDIST,
        MSPEED,
        BGIMASK,
        FMV,
        QUAD,
        ENCOUNT,
        MAPJUMP,
        CC,
        UCOFF,
        UCON,
        MODEL,
        PRINT1,
        PRINTF,
        LOCATE,
        AIDLE,
        AWALK,
        ARUN,
        DIRE,
        ROTXZ,
        BTLCMD,
        MESHSHOW,
        MESHHIDE,
        OBJINDEX,
        ENCSCENE,
        AFRAME,
        ASPEED,
        AMODE,
        ANIM,
        WAITANIM,
        ENDANIM,
        STARTSEQ,
        WAITSEQ,
        ENDSEQ,
        DEBUGCC,
        NECKFLAG,
        ITEMADD,
        ITEMDELETE,
        BTLSET,
        RADIUS,
        ATTACH,
        DETACH,
        WATCH,
        STOP,
        WAITTURN,
        TURNA,
        ASLEEP,
        NOINITMES,
        WAITMES,
        MROT,
        TURN,
        ENCRATE,
        BGSMOVE,
        BGLCOLOR,
        BGLMOVE,
        BGLACTIVE,
        BGLLOOP,
        BGLPARALLAX,
        BGLORIGIN,
        BGAANIME,
        BGAACTIVE,
        BGARATE,
        SETROW,
        BGAWAIT,
        BGAFLAG,
        BGARANGE,
        MESVALUE,
        TWIST,
        FICON,
        TIMERSET,
        DASHOFF,
        CLEARCOLOR,
        PPRINT,
        PPRINTF,
        MAPID,
        BGSSCROLL,
        BGSRELEASE,
        BGCACTIVE,
        BGCHEIGHT,
        BGCLOCK,
        BGCUNLOCK,
        MENU,
        TRACKSTART,
        TRACK,
        TRACKADD,
        PRINTQUAD,
        ATURNL,
        ATURNR,
        CHOOSEPARAM,
        TIMERCONTROL,
        SETCAM,
        SHADOWON,
        SHADOWOFF,
        SHADOWSCALE,
        SHADOWOFFSET,
        SHADOWLOCK,
        SHADOWUNLOCK,
        SHADOWAMP,
        IDLESPEED,
        DDIR,
        CHRFX,
        SEPV,
        SEPVA,
        NECKID,
        ENCOUNT2,
        TIMERDISPLAY,
        RAISE,
        CHRCOLOR,
        SLEEPINH,
        AUTOTURN,
        BGLATTACH,
        CFLAG,
        AJUMP,
        MESA,
        MESAN,
        DRET,
        MOVT,
        TSPEED,
        BGIACTIVET,
        TURNTO,
        PREJUMP,
        POSTJUMP,
        MOVQ,
        CHRSCALE,
        MOVJ,
        POS3,
        MOVE3,
        DRADIUS,
        MJPOS,
        MOVH,
        SPEEDTH,
        TURNDS,
        BGI,
        GETSCREEN,
        MENUON,
        MENUOFF,
        DISCCHANGE,
        DPOS3,
        MINIGAME,
        DELETEALLCARD,
        SETMAPNAME,
        RESETMAPNAME,
        PARTYMENU,
        SPS,
        FULLMEMBER,
        PRETEND,
        WMAPJUMP,
        EYE,
        AIM,
        SETKEYMASK,
        CLEARKEYMASK,
        DTURN,
        DWAITTURN,
        DANIM,
        DWAITANIM,
        DPOS,
        TEXPLAY,
        TEXPLAY1,
        TEXSTOP,
        BGVSET,
        WPRM,
        FLDSND0,
        FLDSND1,
        FLDSND2,
        FLDSND3,
        BGVDEFINE,
        BGAVISIBLE,
        BGIACTIVEF,
        CHRSET,
        CHRCLEAR,
        GILADD,
        GILDELETE,
        MESB,
        GLOBALCLEAR,
        DEBUGSAVE,
        DEBUGLOAD,
        ATTACHOFFSET,
        PUSHHIDE,
        POPSHOW,
        AICON,
        RAIN,
        CLEARSTATUS,
        SPS2,
        WINPOSE,
        JUMP3,
        PARTYDELETE,
        PLAYERNAME,
        OVAL,
        INCFROG,
        BEND,
        SETVY3,
        SETSIGNAL,
        BGLSCROLLOFFSET,
        BTLSEQ,
        BGLLOOPTYPE,
        BGAFRAME,
        MOVE3H,
        SYNCPARTY,
        VRP,
        CLOSEALL,
        WIPERGB,
        BGVALPHA,
        SLEEPON,
        HEREON,
        DASHON,
        SETHP,
        SETMP,
        CLEARAP,
        MAXAP,
        GAMEOVER,
        VIBSTART,
        VIBACTIVE,
        VIBTRACK1,
        VIBTRACK,
        VIBRATE,
        VIBFLAG,
        VIBRANGE,
        HINT,
        JOIN,
        EXT
    }

    public enum event_code_binary_ext
    {
        BSSTART = 65280,
        BSFRAME,
        BSACTIVE,
        BSFLAG,
        BSFLOOR,
        BSRATE,
        BSALGO,
        BSDELTA,
        BSAXIS,
        BAANIME,
        BAFRAME,
        BAACTIVE,
        BAFLAG,
        BARATE,
        BAWAITALL,
        BAWAIT,
        BARANGE,
        BAVISIBLE
    }

    public enum op_binary
    {
        B_PAD0,
        B_PAD1,
        B_PAD2,
        B_PAD3,
        B_POST_PLUS,
        B_POST_MINUS,
        B_PRE_PLUS,
        B_PRE_MINUS,
        B_POST_PLUS_A,
        B_POST_MINUS_A,
        B_PRE_PLUS_A,
        B_PRE_MINUS_A,
        B_SINGLE_PLUS,
        B_SINGLE_MINUS,
        B_NOT,
        B_NOT_E,
        B_COMP,
        B_MULT,
        B_DIV,
        B_REM,
        B_PLUS,
        B_MINUS,
        B_SHIFT_LEFT,
        B_SHIFT_RIGHT,
        B_LT,
        B_GT,
        B_LE,
        B_GE,
        B_LT_E,
        B_GT_E,
        B_LE_E,
        B_GE_E,
        B_EQ,
        B_NE,
        B_EQ_E,
        B_NE_E,
        B_AND,
        B_XOR,
        B_OR,
        B_ANDAND,
        B_OROR,
        B_MEMBER,
        B_COUNT,
        B_PICK,
        B_LET,
        B_LET_A,
        B_LET_E,
        B_MULT_LET,
        B_DIV_LET,
        B_REM_LET,
        B_PLUS_LET,
        B_MINUS_LET,
        B_SHIFT_LEFT_LET,
        B_SHIFT_RIGHT_LET,
        B_MULT_LET_A,
        B_DIV_LET_A,
        B_REM_LET_A,
        B_PLUS_LET_A,
        B_MINUS_LET_A,
        B_SHIFT_LEFT_LET_A,
        B_SHIFT_RIGHT_LET_A,
        B_AND_LET,
        B_XOR_LET,
        B_OR_LET,
        B_AND_LET_A,
        B_XOR_LET_A,
        B_OR_LET_A,
        B_AND_LET_E,
        B_XOR_LET_E,
        B_OR_LET_E,
        B_CAST8,
        B_CAST8U,
        B_CAST16,
        B_CAST16U,
        B_CAST_LIST,
        B_LMAX,
        B_LMIN,
        B_SELECT,
        B_OBJSPEC,
        B_KEYON,
        B_SIN2,
        B_COS2,
        B_CURHP,
        B_MAXHP,
        B_AND_E,
        B_NAND_E,
        B_XOR_E,
        B_OR_E,
        B_KEYOFF,
        B_KEY,
        B_KEYON2,
        B_KEYOFF2,
        B_KEY2,
        B_ANGLE,
        B_DISTANCE,
        B_PTR,
        B_ANGLEA,
        B_DISTANCEA,
        B_SIN,
        B_COS,
        B_HAVE_ITEM,
        B_BAFRAME,
        B_ANGLE2,
        pad67,
        pad68,
        pad69,
        B_FRAME,
        B_PARTYCHK,
        B_SPS,
        B_PARTYADD,
        B_CURMP,
        B_MAXMP,
        B_BGIID,
        B_BGIFLOOR,
        B_OBJSPECA = 120,
        B_SYSLIST,
        B_SYSVAR,
        B_pad7b,
        B_PAD4,
        B_CONST,
        B_CONST4,
        B_EXPR_END,
        B_VAR = 192
    }

    private enum VariableSource
    {
        Global = 0,
        Map = 1,
        Instance = 2,
        Object = 4,
        System = 5,
        Member = 6,
        Int26 = 7
    }

    private enum VariableType
    {
        SBit = 0,
        Bit = 1,
        Int24 = 2,
        UInt24 = 3,
        SByte = 4,
        Byte = 5,
        Int16 = 6,
        UInt16 = 7,
    }
}