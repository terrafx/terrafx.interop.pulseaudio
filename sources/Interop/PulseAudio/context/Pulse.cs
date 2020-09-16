// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/context.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_context *")]
        public static extern IntPtr pa_context_new([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_context *")]
        public static extern IntPtr pa_context_new_with_proplist([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_proplist *")] IntPtr proplist);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_unref([NativeTypeName("pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_context *")]
        public static extern IntPtr pa_context_ref([NativeTypeName("pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_state_callback([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_context_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_event_callback([NativeTypeName("pa_context *")] IntPtr p, [NativeTypeName("pa_context_event_cb_t")] delegate* unmanaged<IntPtr, sbyte*, IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_errno([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_is_pending([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_context_state_t")]
        public static extern pa_context_state pa_context_get_state([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_connect([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* server, [NativeTypeName("pa_context_flags_t")] pa_context_flags flags, [NativeTypeName("const pa_spawn_api *")] pa_spawn_api* api);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_disconnect([NativeTypeName("pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_drain([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_context_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_exit_daemon([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_set_default_sink([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_set_default_source([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_is_local([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_set_name([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_context_get_server([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_protocol_version([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_server_protocol_version([NativeTypeName("const pa_context *")] IntPtr c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_proplist_update([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("const pa_proplist *")] IntPtr p, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_proplist_remove([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *const []")] sbyte** keys, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_index([NativeTypeName("const pa_context *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_time_event *")]
        public static extern IntPtr pa_context_rttime_new([NativeTypeName("const pa_context *")] IntPtr c, [NativeTypeName("pa_usec_t")] nuint usec, [NativeTypeName("pa_time_event_cb_t")] delegate* unmanaged<pa_mainloop_api*, IntPtr, timeval*, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_rttime_restart([NativeTypeName("const pa_context *")] IntPtr c, [NativeTypeName("pa_time_event *")] IntPtr e, [NativeTypeName("pa_usec_t")] nuint usec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_context_get_tile_size([NativeTypeName("const pa_context *")] IntPtr c, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_load_cookie_from_file([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* cookie_file_path);
    }
}
