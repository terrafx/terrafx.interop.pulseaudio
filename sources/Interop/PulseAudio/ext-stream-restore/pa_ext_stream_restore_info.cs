// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-stream-restore.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_ext_stream_restore_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        public pa_channel_map channel_map;

        public pa_cvolume volume;

        [NativeTypeName("const char *")]
        public sbyte* device;

        public int mute;
    }
}
