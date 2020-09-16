// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_mainloop *")]
        public static extern IntPtr pa_mainloop_new();

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_free([NativeTypeName("pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_prepare([NativeTypeName("pa_mainloop *")] IntPtr m, int timeout);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_poll([NativeTypeName("pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_dispatch([NativeTypeName("pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_get_retval([NativeTypeName("const pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_iterate([NativeTypeName("pa_mainloop *")] IntPtr m, int block, [NativeTypeName("int *")] int* retval);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_run([NativeTypeName("pa_mainloop *")] IntPtr m, [NativeTypeName("int *")] int* retval);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_mainloop_api *")]
        public static extern pa_mainloop_api* pa_mainloop_get_api([NativeTypeName("pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_quit([NativeTypeName("pa_mainloop *")] IntPtr m, int retval);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_wakeup([NativeTypeName("pa_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_set_poll_func([NativeTypeName("pa_mainloop *")] IntPtr m, [NativeTypeName("pa_poll_func")] delegate* unmanaged<IntPtr, nuint, int, void*, int> poll_func, [NativeTypeName("void *")] void* userdata);
    }
}
