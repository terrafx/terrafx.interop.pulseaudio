// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_card_port_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint priority;

        public int available;

        public int direction;

        [NativeTypeName("uint32_t")]
        public uint n_profiles;

        [NativeTypeName("pa_card_profile_info **")]
        public pa_card_profile_info** profiles;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        [NativeTypeName("int64_t")]
        public nint latency_offset;

        [NativeTypeName("pa_card_profile_info2 **")]
        public pa_card_profile_info2** profiles2;
    }
}
