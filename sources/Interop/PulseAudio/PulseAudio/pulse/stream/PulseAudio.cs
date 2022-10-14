// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/stream.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_stream* pa_stream_new(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_stream* pa_stream_new_with_proplist(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, pa_proplist* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_stream* pa_stream_new_extended(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_format_info *const *")] pa_format_info** formats, [NativeTypeName("unsigned int")] uint n_formats, pa_proplist* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_unref(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_stream* pa_stream_ref(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_stream_state_t pa_stream_get_state([NativeTypeName("const pa_stream *")] pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_context* pa_stream_get_context([NativeTypeName("const pa_stream *")] pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint pa_stream_get_index([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint pa_stream_get_device_index([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_stream_get_device_name([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_is_suspended([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_is_corked([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_connect_playback(pa_stream* s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, pa_stream_flags_t flags, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, pa_stream* sync_stream);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_connect_record(pa_stream* s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, pa_stream_flags_t flags);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_disconnect(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_begin_write(pa_stream* p, void** data, [NativeTypeName("size_t *")] nuint* nbytes);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_cancel_write(pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_write(pa_stream* p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint nbytes, [NativeTypeName("pa_free_cb_t")] delegate* unmanaged<void*, void> free_cb, [NativeTypeName("int64_t")] nint offset, pa_seek_mode_t seek);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_write_ext_free(pa_stream* p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint nbytes, [NativeTypeName("pa_free_cb_t")] delegate* unmanaged<void*, void> free_cb, void* free_cb_data, [NativeTypeName("int64_t")] nint offset, pa_seek_mode_t seek);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_peek(pa_stream* p, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] nuint* nbytes);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_drop(pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint pa_stream_writable_size([NativeTypeName("const pa_stream *")] pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint pa_stream_readable_size([NativeTypeName("const pa_stream *")] pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_drain(pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_update_timing_info(pa_stream* p, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_state_callback(pa_stream* s, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_write_callback(pa_stream* p, [NativeTypeName("pa_stream_request_cb_t")] delegate* unmanaged<pa_stream*, nuint, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_read_callback(pa_stream* p, [NativeTypeName("pa_stream_request_cb_t")] delegate* unmanaged<pa_stream*, nuint, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_overflow_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern nint pa_stream_get_underflow_index([NativeTypeName("const pa_stream *")] pa_stream* p);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_underflow_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_started_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_latency_update_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_moved_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_suspended_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_event_callback(pa_stream* p, [NativeTypeName("pa_stream_event_cb_t")] delegate* unmanaged<pa_stream*, sbyte*, pa_proplist*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_stream_set_buffer_attr_callback(pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] delegate* unmanaged<pa_stream*, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_cork(pa_stream* s, int b, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_flush(pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_prebuf(pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_trigger(pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_set_name(pa_stream* s, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_get_time(pa_stream* s, [NativeTypeName("pa_usec_t *")] nuint* r_usec);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_get_latency(pa_stream* s, [NativeTypeName("pa_usec_t *")] nuint* r_usec, int* negative);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const pa_timing_info *")]
    public static extern pa_timing_info* pa_stream_get_timing_info(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const pa_sample_spec *")]
    public static extern pa_sample_spec* pa_stream_get_sample_spec(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const pa_channel_map *")]
    public static extern pa_channel_map* pa_stream_get_channel_map(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const pa_format_info *")]
    public static extern pa_format_info* pa_stream_get_format_info([NativeTypeName("const pa_stream *")] pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const pa_buffer_attr *")]
    public static extern pa_buffer_attr* pa_stream_get_buffer_attr(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_set_buffer_attr(pa_stream* s, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_update_sample_rate(pa_stream* s, [NativeTypeName("uint32_t")] uint rate, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_proplist_update(pa_stream* s, pa_update_mode_t mode, pa_proplist* p, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_stream_proplist_remove(pa_stream* s, [NativeTypeName("const char *const []")] sbyte** keys, [NativeTypeName("pa_stream_success_cb_t")] delegate* unmanaged<pa_stream*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_set_monitor_stream(pa_stream* s, [NativeTypeName("uint32_t")] uint sink_input_idx);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint pa_stream_get_monitor_stream([NativeTypeName("const pa_stream *")] pa_stream* s);
}
