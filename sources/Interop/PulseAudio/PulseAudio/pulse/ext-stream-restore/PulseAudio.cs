// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-stream-restore.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_ext_stream_restore_test(pa_context* c, [NativeTypeName("pa_ext_stream_restore_test_cb_t")] delegate* unmanaged<pa_context*, uint, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_ext_stream_restore_read(pa_context* c, [NativeTypeName("pa_ext_stream_restore_read_cb_t")] delegate* unmanaged<pa_context*, pa_ext_stream_restore_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_ext_stream_restore_write(pa_context* c, pa_update_mode_t mode, [NativeTypeName("const pa_ext_stream_restore_info []")] pa_ext_stream_restore_info* data, [NativeTypeName("unsigned int")] uint n, int apply_immediately, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_ext_stream_restore_delete(pa_context* c, [NativeTypeName("const char *const []")] sbyte** s, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_ext_stream_restore_subscribe(pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_ext_stream_restore_set_subscribe_cb(pa_context* c, [NativeTypeName("pa_ext_stream_restore_subscribe_cb_t")] delegate* unmanaged<pa_context*, void*, void> cb, void* userdata);
    }
}
