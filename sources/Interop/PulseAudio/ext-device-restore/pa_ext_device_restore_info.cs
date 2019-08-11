// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-restore.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_ext_device_restore_info
    {
        [NativeTypeName("pa_device_type_t")]
        public pa_device_type type;

        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("uint8_t")]
        public byte n_formats;

        [NativeTypeName("pa_format_info **")]
        public pa_format_info** formats;
    }
}
