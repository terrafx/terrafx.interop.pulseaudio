// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/subscribe.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_subscribe(pa_context* c, pa_subscription_mask_t m, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_subscribe_callback(pa_context* c, [NativeTypeName("pa_context_subscribe_cb_t")] delegate* unmanaged<pa_context*, pa_subscription_event_type_t, uint, void*, void> cb, void* userdata);
    }
}
