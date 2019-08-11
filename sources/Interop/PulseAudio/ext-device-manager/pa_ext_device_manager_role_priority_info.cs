// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-manager.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_ext_device_manager_role_priority_info
    {
        [NativeTypeName("const char *")]
        public sbyte* role;

        [NativeTypeName("uint32_t")]
        public uint priority;
    }
}
