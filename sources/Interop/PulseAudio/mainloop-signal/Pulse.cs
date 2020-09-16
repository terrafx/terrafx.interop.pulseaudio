// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-signal.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_signal_init([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_signal_done();

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_signal_event *")]
        public static extern IntPtr pa_signal_new(int sig, [NativeTypeName("pa_signal_cb_t")] delegate* unmanaged<pa_mainloop_api*, IntPtr, int, void*, void> callback, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_signal_free([NativeTypeName("pa_signal_event *")] IntPtr e);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_signal_set_destroy([NativeTypeName("pa_signal_event *")] IntPtr e, [NativeTypeName("pa_signal_destroy_cb_t")] delegate* unmanaged<pa_mainloop_api*, IntPtr, void*, void> callback);
    }
}
