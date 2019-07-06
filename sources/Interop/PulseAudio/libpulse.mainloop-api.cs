using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public enum pa_io_event_flags : uint
    {
        PA_IO_EVENT_NULL = 0,
        PA_IO_EVENT_INPUT = 1,
        PA_IO_EVENT_OUTPUT = 2,
        PA_IO_EVENT_HANGUP = 4,
        PA_IO_EVENT_ERROR = 8,
    }

    public partial struct pa_io_event
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_io_event_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* ea, [NativeTypeName("pa_io_event *")] pa_io_event* e, int fd, [NativeTypeName("pa_io_event_flags_t")] pa_io_event_flags events, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_io_event_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_io_event *")] pa_io_event* e, [NativeTypeName("void *")] void* userdata);

    public partial struct pa_time_event
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_time_event_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_time_event *")] pa_time_event* e, [NativeTypeName("const struct timeval *")] timeval* tv, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_time_event_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_time_event *")] pa_time_event* e, [NativeTypeName("void *")] void* userdata);

    public partial struct pa_defer_event
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_defer_event_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_defer_event *")] pa_defer_event* e, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_defer_event_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_defer_event *")] pa_defer_event* e, [NativeTypeName("void *")] void* userdata);

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

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_mainloop_api_once", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_mainloop_api_once([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* m, [NativeTypeName("void (*)(pa_mainloop_api *, void *)")] IntPtr callback, [NativeTypeName("void *")] void* userdata);
    }
}
