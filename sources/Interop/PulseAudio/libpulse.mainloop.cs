using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pollfd
    {
    }

    public partial struct pa_mainloop
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int pa_poll_func([NativeTypeName("struct pollfd *")] pollfd* ufds, [NativeTypeName("unsigned long")] UIntPtr nfds, int timeout, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_mainloop_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_mainloop *")]
        public static extern pa_mainloop* pa_mainloop_new();

        [DllImport(DllName, EntryPoint = "pa_mainloop_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_mainloop_free([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_prepare", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_prepare([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int timeout);

        [DllImport(DllName, EntryPoint = "pa_mainloop_poll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_poll([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_dispatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_dispatch([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_get_retval", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_get_retval([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_iterate", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_iterate([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int block, [NativeTypeName("int *")] int* retval);

        [DllImport(DllName, EntryPoint = "pa_mainloop_run", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_mainloop_run([NativeTypeName("pa_mainloop *")] pa_mainloop* m, [NativeTypeName("int *")] int* retval);

        [DllImport(DllName, EntryPoint = "pa_mainloop_get_api", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_mainloop_api *")]
        public static extern pa_mainloop_api* pa_mainloop_get_api([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_quit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_mainloop_quit([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int retval);

        [DllImport(DllName, EntryPoint = "pa_mainloop_wakeup", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_mainloop_wakeup([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_mainloop_set_poll_func", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_mainloop_set_poll_func([NativeTypeName("pa_mainloop *")] pa_mainloop* m, [NativeTypeName("pa_poll_func")] IntPtr poll_func, [NativeTypeName("void *")] void* userdata);
    }
}
