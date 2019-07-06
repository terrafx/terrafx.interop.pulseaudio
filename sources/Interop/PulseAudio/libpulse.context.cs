using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_context
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_notify_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_success_cb_t([NativeTypeName("pa_context *")] pa_context* c, int success, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_event_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_context_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_context *")]
        public static extern pa_context* pa_context_new([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(DllName, EntryPoint = "pa_context_new_with_proplist", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_context *")]
        public static extern pa_context* pa_context_new_with_proplist([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* mainloop, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_proplist *")] pa_proplist* proplist);

        [DllImport(DllName, EntryPoint = "pa_context_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_unref([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_ref", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_context *")]
        public static extern pa_context* pa_context_ref([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_set_state_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_set_state_callback([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_context_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_event_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_set_event_callback([NativeTypeName("pa_context *")] pa_context* p, [NativeTypeName("pa_context_event_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_errno", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_context_errno([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_is_pending", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_context_is_pending([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_get_state", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_context_state_t")]
        public static extern pa_context_state pa_context_get_state([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_connect", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_context_connect([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* server, [NativeTypeName("pa_context_flags_t")] pa_context_flags flags, [NativeTypeName("const pa_spawn_api *")] pa_spawn_api* api);

        [DllImport(DllName, EntryPoint = "pa_context_disconnect", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_disconnect([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_drain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_drain([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_context_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_exit_daemon", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_exit_daemon([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_default_sink", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_default_sink([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_default_source", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_default_source([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_is_local", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_context_is_local([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_set_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_server", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_context_get_server([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_get_protocol_version", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_protocol_version([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_get_server_protocol_version", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_server_protocol_version([NativeTypeName("pa_context *")] pa_context* c);

        [DllImport(DllName, EntryPoint = "pa_context_proplist_update", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_proplist_update([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_proplist_remove", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_proplist_remove([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *const []")] sbyte* keys, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_context_get_index([NativeTypeName("pa_context *")] pa_context* s);

        [DllImport(DllName, EntryPoint = "pa_context_rttime_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_time_event *")]
        public static extern pa_time_event* pa_context_rttime_new([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_usec_t")] UIntPtr usec, [NativeTypeName("pa_time_event_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_rttime_restart", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_rttime_restart([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_time_event *")] pa_time_event* e, [NativeTypeName("pa_usec_t")] UIntPtr usec);

        [DllImport(DllName, EntryPoint = "pa_context_get_tile_size", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr pa_context_get_tile_size([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport(DllName, EntryPoint = "pa_context_load_cookie_from_file", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_context_load_cookie_from_file([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* cookie_file_path);
    }
}