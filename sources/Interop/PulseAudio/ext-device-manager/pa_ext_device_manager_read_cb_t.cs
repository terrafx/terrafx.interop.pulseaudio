// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-manager.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_ext_device_manager_read_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_ext_device_manager_info *")] pa_ext_device_manager_info* info, int eol, [NativeTypeName("void *")] void* userdata);
}
