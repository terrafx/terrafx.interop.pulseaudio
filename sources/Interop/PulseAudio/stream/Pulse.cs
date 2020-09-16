// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/stream.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_stream *")]
        public static extern IntPtr pa_stream_new([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_stream *")]
        public static extern IntPtr pa_stream_new_with_proplist([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_proplist *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_stream *")]
        public static extern IntPtr pa_stream_new_extended([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_format_info *const *")] pa_format_info** formats, [NativeTypeName("unsigned int")] uint n_formats, [NativeTypeName("pa_proplist *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_unref([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_stream *")]
        public static extern IntPtr pa_stream_ref([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_stream_state_t")]
        public static extern pa_stream_state pa_stream_get_state([NativeTypeName("const pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_context *")]
        public static extern IntPtr pa_stream_get_context([NativeTypeName("const pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_index([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_device_index([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_stream_get_device_name([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_is_suspended([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_is_corked([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_connect_playback([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_flags_t")] pa_stream_flags flags, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_stream *")] IntPtr sync_stream);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_connect_record([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_flags_t")] pa_stream_flags flags);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_disconnect([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_begin_write([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("void **")] void** data, [NativeTypeName("size_t *")] nuint* nbytes);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_cancel_write([NativeTypeName("pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_write([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint nbytes, [NativeTypeName("pa_free_cb_t")] delegate* unmanaged<void*, void> free_cb, [NativeTypeName("int64_t")] nint offset, [NativeTypeName("pa_seek_mode_t")] pa_seek_mode seek);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_write_ext_free([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint nbytes, [NativeTypeName("pa_free_cb_t")] delegate* unmanaged<void*, void> free_cb, [NativeTypeName("void *")] void* free_cb_data, [NativeTypeName("int64_t")] nint offset, [NativeTypeName("pa_seek_mode_t")] pa_seek_mode seek);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_peek([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] nuint* nbytes);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_drop([NativeTypeName("pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_stream_writable_size([NativeTypeName("const pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_stream_readable_size([NativeTypeName("const pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_drain([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_update_timing_info([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_state_callback([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_write_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_request_cb_t")] delegate* unmanaged<IntPtr, nuint, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_read_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_request_cb_t")] delegate* unmanaged<IntPtr, nuint, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_overflow_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern nint pa_stream_get_underflow_index([NativeTypeName("const pa_stream *")] IntPtr p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_underflow_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_started_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_latency_update_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_moved_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_suspended_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_event_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_event_cb_t")] delegate* unmanaged<IntPtr, sbyte*, IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_stream_set_buffer_attr_callback([NativeTypeName("pa_stream *")] IntPtr p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_cork([NativeTypeName("pa_stream *")] IntPtr s, int b, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_flush([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_prebuf([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_trigger([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_set_name([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_get_time([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_usec_t *")] nuint* r_usec);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_get_latency([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_usec_t *")] nuint* r_usec, [NativeTypeName("int *")] int* negative);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const pa_timing_info *")]
        public static extern pa_timing_info* pa_stream_get_timing_info([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const pa_sample_spec *")]
        public static extern pa_sample_spec* pa_stream_get_sample_spec([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const pa_channel_map *")]
        public static extern pa_channel_map* pa_stream_get_channel_map([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const pa_format_info *")]
        public static extern pa_format_info* pa_stream_get_format_info([NativeTypeName("const pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const pa_buffer_attr *")]
        public static extern pa_buffer_attr* pa_stream_get_buffer_attr([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_set_buffer_attr([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_update_sample_rate([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("uint32_t")] uint rate, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_proplist_update([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("pa_proplist *")] IntPtr p, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_stream_proplist_remove([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("const char *const []")] sbyte** keys, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_set_monitor_stream([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("uint32_t")] uint sink_input_idx);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_monitor_stream([NativeTypeName("const pa_stream *")] IntPtr s);
    }
}
