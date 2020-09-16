// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_mainloop_api
    {
        [NativeTypeName("void *")]
        public void* userdata;

        [NativeTypeName("pa_io_event *(*)(pa_mainloop_api *, int, pa_io_event_flags_t, pa_io_event_cb_t, void *)")]
        public IntPtr io_new;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_flags_t)")]
        public IntPtr io_enable;

        [NativeTypeName("void (*)(pa_io_event *)")]
        public IntPtr io_free;

        [NativeTypeName("void (*)(pa_io_event *, pa_io_event_destroy_cb_t)")]
        public IntPtr io_set_destroy;

        [NativeTypeName("pa_time_event *(*)(pa_mainloop_api *, const struct timeval *, pa_time_event_cb_t, void *)")]
        public IntPtr time_new;

        [NativeTypeName("void (*)(pa_time_event *, const struct timeval *)")]
        public IntPtr time_restart;

        [NativeTypeName("void (*)(pa_time_event *)")]
        public IntPtr time_free;

        [NativeTypeName("void (*)(pa_time_event *, pa_time_event_destroy_cb_t)")]
        public IntPtr time_set_destroy;

        [NativeTypeName("pa_defer_event *(*)(pa_mainloop_api *, pa_defer_event_cb_t, void *)")]
        public IntPtr defer_new;

        [NativeTypeName("void (*)(pa_defer_event *, int)")]
        public IntPtr defer_enable;

        [NativeTypeName("void (*)(pa_defer_event *)")]
        public IntPtr defer_free;

        [NativeTypeName("void (*)(pa_defer_event *, pa_defer_event_destroy_cb_t)")]
        public IntPtr defer_set_destroy;

        [NativeTypeName("void (*)(pa_mainloop_api *, int)")]
        public IntPtr quit;
    }
}
