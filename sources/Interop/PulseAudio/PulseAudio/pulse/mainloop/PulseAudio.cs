// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_mainloop* pa_mainloop_new();

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_free(pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_prepare(pa_mainloop* m, int timeout);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_poll(pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_dispatch(pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_get_retval([NativeTypeName("const pa_mainloop *")] pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_iterate(pa_mainloop* m, int block, int* retval);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_mainloop_run(pa_mainloop* m, int* retval);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_mainloop_api* pa_mainloop_get_api(pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_quit(pa_mainloop* m, int retval);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_wakeup(pa_mainloop* m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_set_poll_func(pa_mainloop* m, [NativeTypeName("pa_poll_func")] delegate* unmanaged<pollfd*, nuint, int, void*, int> poll_func, void* userdata);
    }
}
