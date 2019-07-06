using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_subscribe_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_subscription_event_type_t")] pa_subscription_event_type t, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_context_subscribe", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_subscribe([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_subscription_mask_t")] pa_subscription_mask m, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_subscribe_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_context_set_subscribe_callback([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_context_subscribe_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
