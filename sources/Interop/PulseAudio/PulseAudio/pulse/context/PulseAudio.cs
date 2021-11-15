// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/context.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_context* pa_context_new(pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_context* pa_context_new_with_proplist(pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_proplist *")] pa_proplist* proplist);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_unref(pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_context* pa_context_ref(pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_state_callback(pa_context* c, [NativeTypeName("pa_context_notify_cb_t")] delegate* unmanaged<pa_context*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_set_event_callback(pa_context* p, [NativeTypeName("pa_context_event_cb_t")] delegate* unmanaged<pa_context*, sbyte*, pa_proplist*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_errno([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_is_pending([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_context_state_t pa_context_get_state([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_connect(pa_context* c, [NativeTypeName("const char *")] sbyte* server, pa_context_flags_t flags, [NativeTypeName("const pa_spawn_api *")] pa_spawn_api* api);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_disconnect(pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_drain(pa_context* c, [NativeTypeName("pa_context_notify_cb_t")] delegate* unmanaged<pa_context*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_exit_daemon(pa_context* c, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_default_sink(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_default_source(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_is_local([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_context_get_server([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_protocol_version([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_server_protocol_version([NativeTypeName("const pa_context *")] pa_context* c);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_proplist_update(pa_context* c, pa_update_mode_t mode, [NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_proplist_remove(pa_context* c, [NativeTypeName("const char *const []")] sbyte** keys, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_index([NativeTypeName("const pa_context *")] pa_context* s);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_time_event* pa_context_rttime_new([NativeTypeName("const pa_context *")] pa_context* c, [NativeTypeName("pa_usec_t")] nuint usec, [NativeTypeName("pa_time_event_cb_t")] delegate* unmanaged<pa_mainloop_api*, pa_time_event*, timeval*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_context_rttime_restart([NativeTypeName("const pa_context *")] pa_context* c, pa_time_event* e, [NativeTypeName("pa_usec_t")] nuint usec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_context_get_tile_size([NativeTypeName("const pa_context *")] pa_context* c, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_context_load_cookie_from_file(pa_context* c, [NativeTypeName("const char *")] sbyte* cookie_file_path);
    }
}
