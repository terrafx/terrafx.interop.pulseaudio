// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-signal.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_signal_init(pa_mainloop_api* api);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_signal_done();

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_signal_event* pa_signal_new(int sig, [NativeTypeName("pa_signal_cb_t")] delegate* unmanaged<pa_mainloop_api*, pa_signal_event*, int, void*, void> callback, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_signal_free(pa_signal_event* e);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_signal_set_destroy(pa_signal_event* e, [NativeTypeName("pa_signal_destroy_cb_t")] delegate* unmanaged<pa_mainloop_api*, pa_signal_event*, void*, void> callback);
}
