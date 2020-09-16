// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/subscribe.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_subscribe([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_subscription_mask_t")] pa_subscription_mask m, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_subscribe_callback([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_context_subscribe_cb_t")] delegate* unmanaged<IntPtr, pa_subscription_event_type, uint, void*, void> cb, [NativeTypeName("void *")] void* userdata);
    }
}
