// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_sample_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        public pa_cvolume volume;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("pa_usec_t")]
        public nuint duration;

        [NativeTypeName("uint32_t")]
        public uint bytes;

        public int lazy;

        [NativeTypeName("const char *")]
        public sbyte* filename;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;
    }
}
