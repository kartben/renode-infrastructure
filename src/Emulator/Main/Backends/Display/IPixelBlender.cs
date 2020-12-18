//
// Copyright (c) 2010-2018 Antmicro
// Copyright (c) 2011-2015 Realtime Embedded
//
// This file is licensed under the MIT License.
// Full license text is available in 'licenses/MIT.txt'.
//
using System;

namespace Antmicro.Renode.Backends.Display
{
    public interface IPixelBlender
    {
        void Blend(byte[] backBuffer, byte[] frontBuffer, ref byte[] output, Pixel background = null, byte backBufferAlphaMultiplayer = 0xFF, PixelBlendingMode backgroundBlendingMode = PixelBlendingMode.MULTIPLY, byte frontBufferAlphaMultiplayer = 0xFF, PixelBlendingMode foregroundBlendingMode = PixelBlendingMode.MULTIPLY);
        void Blend(byte[] backBuffer, byte[] backClutBuffer, byte[] frontBuffer, byte[] frontClutBuffer, ref byte[] output, Pixel background = null, byte backBufferAlphaMultiplayer = 0xFF, PixelBlendingMode bgBlendingMode = default(PixelBlendingMode), byte frontBufferAlphaMultiplayer = 0xFF, PixelBlendingMode foregroundBlendingMode = PixelBlendingMode.MULTIPLY);

        PixelFormat BackBuffer { get; }
        PixelFormat FrontBuffer { get; }
        PixelFormat Output { get; }
    }
    public enum PixelBlendingMode
    {
        NO_MODIFICATION,
        REPLACE,
        MULTIPLY
    }

}

