using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_operation
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_operation_notify_cb_t([NativeTypeName("pa_operation *")] pa_operation* o, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_operation_ref", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_operation_ref([NativeTypeName("pa_operation *")] pa_operation* o);

        [DllImport(DllName, EntryPoint = "pa_operation_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_operation_unref([NativeTypeName("pa_operation *")] pa_operation* o);

        [DllImport(DllName, EntryPoint = "pa_operation_cancel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_operation_cancel([NativeTypeName("pa_operation *")] pa_operation* o);

        [DllImport(DllName, EntryPoint = "pa_operation_get_state", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation_state_t")]
        public static extern pa_operation_state pa_operation_get_state([NativeTypeName("pa_operation *")] pa_operation* o);

        [DllImport(DllName, EntryPoint = "pa_operation_set_state_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_operation_set_state_callback([NativeTypeName("pa_operation *")] pa_operation* o, [NativeTypeName("pa_operation_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
