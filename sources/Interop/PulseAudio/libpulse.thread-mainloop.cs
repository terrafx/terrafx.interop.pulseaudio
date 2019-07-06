using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_threaded_mainloop
    {
    }

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_threaded_mainloop *")]
        public static extern pa_threaded_mainloop* pa_threaded_mainloop_new();

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_free([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_start", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_threaded_mainloop_start([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_stop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_stop([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_lock", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_lock([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_unlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_unlock([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_wait", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_wait([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_signal", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_signal([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m, int wait_for_accept);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_accept", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_accept([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_get_retval", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_threaded_mainloop_get_retval([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_get_api", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_mainloop_api *")]
        public static extern pa_mainloop_api* pa_threaded_mainloop_get_api([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_in_thread", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_threaded_mainloop_in_thread([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m);

        [DllImport(DllName, EntryPoint = "pa_threaded_mainloop_set_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_threaded_mainloop_set_name([NativeTypeName("pa_threaded_mainloop *")] pa_threaded_mainloop* m, [NativeTypeName("const char *")] sbyte* name);
    }
}