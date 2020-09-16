// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-stream-restore.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_stream_restore_test([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_stream_restore_test_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_stream_restore_read([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_stream_restore_read_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_stream_restore_write([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("const pa_ext_stream_restore_info []")] pa_ext_stream_restore_info* data, [NativeTypeName("unsigned int")] uint n, int apply_immediately, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_stream_restore_delete([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *const []")] sbyte** s, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_ext_stream_restore_subscribe([NativeTypeName("pa_context *")] pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_ext_stream_restore_set_subscribe_cb([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_ext_stream_restore_subscribe_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
