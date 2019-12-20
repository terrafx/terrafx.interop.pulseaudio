// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/ext-device-restore.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_restore_test([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_restore_test_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_subscribe", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_restore_subscribe([NativeTypeName("pa_context *")] pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_set_subscribe_cb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_ext_device_restore_set_subscribe_cb([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_restore_subscribe_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_read_formats_all", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_restore_read_formats_all([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_read_formats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_restore_read_formats([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_device_type_t")] pa_device_type type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(LibraryPath, EntryPoint = "pa_ext_device_restore_save_formats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_device_restore_save_formats([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_device_type_t")] pa_device_type type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint8_t")] byte n_formats, [NativeTypeName("pa_format_info **")] pa_format_info** formats, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
