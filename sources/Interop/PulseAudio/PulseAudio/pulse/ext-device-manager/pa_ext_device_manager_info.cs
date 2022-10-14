// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-manager.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public unsafe partial struct pa_ext_device_manager_info
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("const char *")]
    public sbyte* description;

    [NativeTypeName("const char *")]
    public sbyte* icon;

    [NativeTypeName("uint32_t")]
    public uint index;

    [NativeTypeName("uint32_t")]
    public uint n_role_priorities;

    public pa_ext_device_manager_role_priority_info* role_priorities;
}
