// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop-signal.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_signal_init", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_signal_init([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api);

        [DllImport(libraryPath, EntryPoint = "pa_signal_done", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_signal_done();

        [DllImport(libraryPath, EntryPoint = "pa_signal_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_signal_event *")]
        public static extern pa_signal_event* pa_signal_new(int sig, [NativeTypeName("pa_signal_cb_t")] IntPtr callback, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_signal_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_signal_free([NativeTypeName("pa_signal_event *")] pa_signal_event* e);

        [DllImport(libraryPath, EntryPoint = "pa_signal_set_destroy", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_signal_set_destroy([NativeTypeName("pa_signal_event *")] pa_signal_event* e, [NativeTypeName("pa_signal_destroy_cb_t")] IntPtr callback);
    }
}
