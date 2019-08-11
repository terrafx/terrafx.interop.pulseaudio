// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/channelmap.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

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
            internal pa_channel_position e0;
            internal pa_channel_position e1;
            internal pa_channel_position e2;
            internal pa_channel_position e3;
            internal pa_channel_position e4;
            internal pa_channel_position e5;
            internal pa_channel_position e6;
            internal pa_channel_position e7;
            internal pa_channel_position e8;
            internal pa_channel_position e9;
            internal pa_channel_position e10;
            internal pa_channel_position e11;
            internal pa_channel_position e12;
            internal pa_channel_position e13;
            internal pa_channel_position e14;
            internal pa_channel_position e15;
            internal pa_channel_position e16;
            internal pa_channel_position e17;
            internal pa_channel_position e18;
            internal pa_channel_position e19;
            internal pa_channel_position e20;
            internal pa_channel_position e21;
            internal pa_channel_position e22;
            internal pa_channel_position e23;
            internal pa_channel_position e24;
            internal pa_channel_position e25;
            internal pa_channel_position e26;
            internal pa_channel_position e27;
            internal pa_channel_position e28;
            internal pa_channel_position e29;
            internal pa_channel_position e30;
            internal pa_channel_position e31;

            public unsafe ref pa_channel_position this[int index]
            {
                get
                {
                    fixed (pa_channel_position* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
