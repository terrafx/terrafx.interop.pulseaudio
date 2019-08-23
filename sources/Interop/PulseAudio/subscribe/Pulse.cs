// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/subscribe.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_context_subscribe", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_subscribe([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_subscription_mask_t")] pa_subscription_mask m, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_subscribe_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_set_subscribe_callback([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_context_subscribe_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}