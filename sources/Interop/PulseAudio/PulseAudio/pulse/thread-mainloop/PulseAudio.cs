// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/thread-mainloop.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_threaded_mainloop* pa_threaded_mainloop_new();

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_free(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_threaded_mainloop_start(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_stop(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_lock(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_unlock(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_wait(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_signal(pa_threaded_mainloop* m, int wait_for_accept);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_accept(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_threaded_mainloop_get_retval([NativeTypeName("const pa_threaded_mainloop *")] pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_mainloop_api* pa_threaded_mainloop_get_api(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_threaded_mainloop_in_thread(pa_threaded_mainloop* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_set_name(pa_threaded_mainloop* m, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_threaded_mainloop_once_unlocked(pa_threaded_mainloop* m, [NativeTypeName("void (*)(pa_threaded_mainloop *, void *)")] delegate* unmanaged<pa_threaded_mainloop*, void*, void> callback, void* userdata);
}
