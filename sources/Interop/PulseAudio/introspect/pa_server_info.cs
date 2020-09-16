// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_server_info
    {
        [NativeTypeName("const char *")]
        public sbyte* user_name;

        [NativeTypeName("const char *")]
        public sbyte* host_name;

        [NativeTypeName("const char *")]
        public sbyte* server_version;

        [NativeTypeName("const char *")]
        public sbyte* server_name;

        public pa_sample_spec sample_spec;

        [NativeTypeName("const char *")]
        public sbyte* default_sink_name;

        [NativeTypeName("const char *")]
        public sbyte* default_source_name;

        [NativeTypeName("uint32_t")]
        public uint cookie;

        public pa_channel_map channel_map;
    }
}
