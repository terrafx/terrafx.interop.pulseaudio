using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_signal_event
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_signal_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api, [NativeTypeName("pa_signal_event *")] pa_signal_event* e, int sig, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_signal_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api, [NativeTypeName("pa_signal_event *")] pa_signal_event* e, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_signal_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_signal_init([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api);

        [DllImport(DllName, EntryPoint = "pa_signal_done", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_signal_done();

        [DllImport(DllName, EntryPoint = "pa_signal_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_signal_event *")]
        public static extern pa_signal_event* pa_signal_new(int sig, [NativeTypeName("pa_signal_cb_t")] IntPtr callback, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_signal_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_signal_free([NativeTypeName("pa_signal_event *")] pa_signal_event* e);

        [DllImport(DllName, EntryPoint = "pa_signal_set_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_signal_set_destroy([NativeTypeName("pa_signal_event *")] pa_signal_event* e, [NativeTypeName("pa_signal_destroy_cb_t")] IntPtr callback);
    }
}
