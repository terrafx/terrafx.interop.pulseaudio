// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-restore.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_restore_test([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_restore_test_cb_t")] delegate* unmanaged<IntPtr, uint, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_restore_subscribe([NativeTypeName("pa_context *")] IntPtr c, int enable, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_ext_device_restore_set_subscribe_cb([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_restore_subscribe_cb_t")] delegate* unmanaged<IntPtr, pa_device_type, uint, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_restore_read_formats_all([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] delegate* unmanaged<IntPtr, pa_ext_device_restore_info*, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_restore_read_formats([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_device_type_t")] pa_device_type type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] delegate* unmanaged<IntPtr, pa_ext_device_restore_info*, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_ext_device_restore_save_formats([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("pa_device_type_t")] pa_device_type type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint8_t")] byte n_formats, [NativeTypeName("pa_format_info **")] pa_format_info** formats, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);
    }
}
