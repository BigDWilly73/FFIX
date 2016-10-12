﻿/////////////////////////////////////////////////////////////////////////////////
//
// Photoshop PSD FileType Plugin for Paint.NET
// http://psdplugin.codeplex.com/
//
// This software is provided under the MIT License:
//   Copyright (c) 2006-2007 Frank Blumenberg
//   Copyright (c) 2010-2016 Tao Yue
//

//
/////////////////////////////////////////////////////////////////////////////////

namespace Memoria.PSD.Compression
{
  public class EndianReverser : ImageData
  {
    private ImageData _imageData;

    protected override bool AltersWrittenData
    {
      get { return true; }
    }

    public EndianReverser(ImageData imageData)
      : base(imageData.Size, imageData.BitDepth)
    {
      this._imageData = imageData;
    }

    internal override void Read(byte[] buffer)
    {
      _imageData.Read(buffer);

      var numPixels = Size.Width * Size.Height;
      if (numPixels == 0)
      {
        return;
      }
      Util.SwapByteArray(BitDepth, buffer, 0, numPixels);
    }

    public override byte[] ReadCompressed()
    {
      return _imageData.ReadCompressed();
    }

    internal override void WriteInternal(byte[] array)
    {
      // Reverse endianness before passing on to underlying compressor
      if (array.Length > 0)
      {
        var numPixels = array.Length / BytesPerRow * Size.Width;
        Util.SwapByteArray(BitDepth, array, 0, numPixels);
      }

      _imageData.Write(array);
    }
  }
}
