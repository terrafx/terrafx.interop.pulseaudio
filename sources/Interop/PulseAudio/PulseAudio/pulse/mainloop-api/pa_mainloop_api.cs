// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio
{
    public unsafe partial struct pa_mainloop_api
    {
        public void* userdata;

        [NativeTypeName("pa_io_event *(*)(pa_mainloop_api *, int, pa_io_event_flags_t, pa_io_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, int, pa_io_event_flags_t, delegate* unmanaged<pa_mainloop_api*, pa_io_event*, int, pa_io_event_flags_t, void*, void>, void*, pa_io_event*> io_new;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_flags_t)")]
        public delegate* unmanaged<pa_io_event*, pa_io_event_flags_t, void> io_enable;

        [NativeTypeName("void (*)(pa_io_event *)")]
        public delegate* unmanaged<pa_io_event*, void> io_free;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_destroy_cb_t)")]
        public delegate* unmanaged<pa_io_event*, delegate* unmanaged<pa_mainloop_api*, pa_io_event*, void*, void>, void> io_set_destroy;

        [NativeTypeName("pa_time_event *(*)(pa_mainloop_api *, const struct timeval *, pa_time_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, timeval*, delegate* unmanaged<pa_mainloop_api*, pa_time_event*, timeval*, void*, void>, void*, pa_time_event*> time_new;

        [NativeTypeName("void (*)(pa_time_event *, const struct timeval *)")]
        public delegate* unmanaged<pa_time_event*, timeval*, void> time_restart;

        [NativeTypeName("void (*)(pa_time_event *)")]
        public delegate* unmanaged<pa_time_event*, void> time_free;

        [NativeTypeName("void (*)(pa_time_event *, pa_time_event_destroy_cb_t)")]
        public delegate* unmanaged<pa_time_event*, delegate* unmanaged<pa_mainloop_api*, pa_time_event*, void*, void>, void> time_set_destroy;

        [NativeTypeName("pa_defer_event *(*)(pa_mainloop_api *, pa_defer_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, delegate* unmanaged<pa_mainloop_api*, pa_defer_event*, void*, void>, void*, pa_defer_event*> defer_new;

        [NativeTypeName("void (*)(pa_defer_event *, int)")]
        public delegate* unmanaged<pa_defer_event*, int, void> defer_enable;

        [NativeTypeName("void (*)(pa_defer_event *)")]
        public delegate* unmanaged<pa_defer_event*, void> defer_free;

        [NativeTypeName("void (*)(pa_defer_event *, pa_defer_event_destroy_cb_t)")]
        public delegate* unmanaged<pa_defer_event*, delegate* unmanaged<pa_mainloop_api*, pa_defer_event*, void*, void>, void> defer_set_destroy;

        [NativeTypeName("void (*)(pa_mainloop_api *, int)")]
        public delegate* unmanaged<pa_mainloop_api*, int, void> quit;
    }
}
