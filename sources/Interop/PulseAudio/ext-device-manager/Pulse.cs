// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-manager.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_test", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_test([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_manager_test_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_read", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_read([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_manager_read_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_set_device_description", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_set_device_description([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* device, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_delete", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_delete([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *const []")] sbyte* s, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_enable_role_device_priority_routing", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_enable_role_device_priority_routing([NativeTypeName("pa_context *")] pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_reorder_devices_for_role", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_reorder_devices_for_role([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* role, [NativeTypeName("const char **")] sbyte** devices, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_subscribe", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_manager_subscribe([NativeTypeName("pa_context *")] pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_ext_device_manager_set_subscribe_cb", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_ext_device_manager_set_subscribe_cb([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_manager_subscribe_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
