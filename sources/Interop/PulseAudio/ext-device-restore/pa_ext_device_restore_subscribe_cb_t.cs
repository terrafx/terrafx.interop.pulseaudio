// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-restore.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void pa_ext_device_restore_subscribe_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_device_type_t")] pa_device_type type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("void *")] void* userdata);
}
