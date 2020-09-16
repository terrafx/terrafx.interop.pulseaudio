// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/channelmap.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_channel_map
    {
        [NativeTypeName("uint8_t")]
        public byte channels;

        [NativeTypeName("pa_channel_position_t [32]")]
        public _map_e__FixedBuffer map;

        public partial struct _map_e__FixedBuffer
        {
            public pa_channel_position e0;
            public pa_channel_position e1;
            public pa_channel_position e2;
            public pa_channel_position e3;
            public pa_channel_position e4;
            public pa_channel_position e5;
            public pa_channel_position e6;
            public pa_channel_position e7;
            public pa_channel_position e8;
            public pa_channel_position e9;
            public pa_channel_position e10;
            public pa_channel_position e11;
            public pa_channel_position e12;
            public pa_channel_position e13;
            public pa_channel_position e14;
            public pa_channel_position e15;
            public pa_channel_position e16;
            public pa_channel_position e17;
            public pa_channel_position e18;
            public pa_channel_position e19;
            public pa_channel_position e20;
            public pa_channel_position e21;
            public pa_channel_position e22;
            public pa_channel_position e23;
            public pa_channel_position e24;
            public pa_channel_position e25;
            public pa_channel_position e26;
            public pa_channel_position e27;
            public pa_channel_position e28;
            public pa_channel_position e29;
            public pa_channel_position e30;
            public pa_channel_position e31;

            public ref pa_channel_position this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<pa_channel_position> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
