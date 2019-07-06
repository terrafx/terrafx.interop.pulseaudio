using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_play_sample_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_stream_connect_upload", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_connect_upload([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport(DllName, EntryPoint = "pa_stream_finish_upload", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_finish_upload([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(DllName, EntryPoint = "pa_context_remove_sample", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_sample([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_play_sample", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_play_sample([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_play_sample_with_proplist", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_play_sample_with_proplist([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("pa_proplist *")] pa_proplist* proplist, [NativeTypeName("pa_context_play_sample_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
