// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-manager.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
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

        [NativeTypeName("pa_ext_device_manager_role_priority_info *")]
        public pa_ext_device_manager_role_priority_info* role_priorities;
    }
}
