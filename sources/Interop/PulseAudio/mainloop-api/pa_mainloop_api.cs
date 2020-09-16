// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_mainloop_api
    {
        [NativeTypeName("void *")]
        public void* userdata;

        [NativeTypeName("pa_io_event *(*)(pa_mainloop_api *, int, pa_io_event_flags_t, pa_io_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, int, pa_io_event_flags, delegate* unmanaged<pa_mainloop_api*, IntPtr, int, pa_io_event_flags, void*, void>, void*, IntPtr> io_new;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_flags_t)")]
        public delegate* unmanaged<IntPtr, pa_io_event_flags, void> io_enable;

        [NativeTypeName("void (*)(pa_io_event *)")]
        public delegate* unmanaged<IntPtr, void> io_free;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_destroy_cb_t)")]
        public delegate* unmanaged<IntPtr, delegate* unmanaged<pa_mainloop_api*, IntPtr, void*, void>, void> io_set_destroy;

        [NativeTypeName("pa_time_event *(*)(pa_mainloop_api *, const struct timeval *, pa_time_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, timeval*, delegate* unmanaged<pa_mainloop_api*, IntPtr, timeval*, void*, void>, void*, IntPtr> time_new;

        [NativeTypeName("void (*)(pa_time_event *, const struct timeval *)")]
        public delegate* unmanaged<IntPtr, timeval*, void> time_restart;

        [NativeTypeName("void (*)(pa_time_event *)")]
        public delegate* unmanaged<IntPtr, void> time_free;

        [NativeTypeName("void (*)(pa_time_event *, pa_time_event_destroy_cb_t)")]
        public delegate* unmanaged<IntPtr, delegate* unmanaged<pa_mainloop_api*, IntPtr, void*, void>, void> time_set_destroy;

        [NativeTypeName("pa_defer_event *(*)(pa_mainloop_api *, pa_defer_event_cb_t, void *)")]
        public delegate* unmanaged<pa_mainloop_api*, delegate* unmanaged<pa_mainloop_api*, IntPtr, void*, void>, void*, IntPtr> defer_new;

        [NativeTypeName("void (*)(pa_defer_event *, int)")]
        public delegate* unmanaged<IntPtr, int, void> defer_enable;

        [NativeTypeName("void (*)(pa_defer_event *)")]
        public delegate* unmanaged<IntPtr, void> defer_free;

        [NativeTypeName("void (*)(pa_defer_event *, pa_defer_event_destroy_cb_t)")]
        public delegate* unmanaged<IntPtr, delegate* unmanaged<pa_mainloop_api*, IntPtr, void*, void>, void> defer_set_destroy;

        [NativeTypeName("void (*)(pa_mainloop_api *, int)")]
        public delegate* unmanaged<pa_mainloop_api*, int, void> quit;
    }
}
