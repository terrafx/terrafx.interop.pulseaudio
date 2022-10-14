// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-restore.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public unsafe partial struct pa_ext_device_restore_info
{
    public pa_device_type_t type;

    [NativeTypeName("uint32_t")]
    public uint index;

    [NativeTypeName("uint8_t")]
    public byte n_formats;

    public pa_format_info** formats;
}
