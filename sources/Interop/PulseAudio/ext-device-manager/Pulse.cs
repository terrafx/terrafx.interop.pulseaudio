// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-manager.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_test([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_manager_test_cb_t")] delegate* unmanaged<IntPtr, uint, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_read([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_manager_read_cb_t")] delegate* unmanaged<IntPtr, pa_ext_device_manager_info*, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_set_device_description([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* device, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_delete([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *const []")] sbyte** s, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_enable_role_device_priority_routing([NativeTypeName("pa_context *")] IntPtr c, int enable, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_reorder_devices_for_role([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* role, [NativeTypeName("const char **")] sbyte** devices, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_manager_subscribe([NativeTypeName("pa_context *")] IntPtr c, int enable, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_ext_device_manager_set_subscribe_cb([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_manager_subscribe_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);
    }
}
