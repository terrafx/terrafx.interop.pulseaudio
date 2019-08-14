// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/stream.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_stream_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_stream *")]
        public static extern pa_stream* pa_stream_new([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(libraryPath, EntryPoint = "pa_stream_new_with_proplist", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_stream *")]
        public static extern pa_stream* pa_stream_new_with_proplist([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_new_extended", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_stream *")]
        public static extern pa_stream* pa_stream_new_extended([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_format_info *const *")] pa_format_info** formats, [NativeTypeName("unsigned int")] uint n_formats, [NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_unref([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_ref", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_stream *")]
        public static extern pa_stream* pa_stream_ref([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_state", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_stream_state_t")]
        public static extern pa_stream_state pa_stream_get_state([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_context", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_context *")]
        public static extern pa_context* pa_stream_get_context([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_index([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_device_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_device_index([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_device_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_stream_get_device_name([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_is_suspended", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_is_suspended([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_is_corked", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_is_corked([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_connect_playback", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_connect_playback([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_flags_t")] pa_stream_flags flags, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_stream *")] pa_stream* sync_stream);

        [DllImport(libraryPath, EntryPoint = "pa_stream_connect_record", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_connect_record([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_flags_t")] pa_stream_flags flags);

        [DllImport(libraryPath, EntryPoint = "pa_stream_disconnect", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_disconnect([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_begin_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_begin_write([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("void **")] void** data, [NativeTypeName("size_t *")] UIntPtr* nbytes);

        [DllImport(libraryPath, EntryPoint = "pa_stream_cancel_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_cancel_write([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_write([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr nbytes, [NativeTypeName("pa_free_cb_t")] IntPtr free_cb, [NativeTypeName("int64_t")] IntPtr offset, [NativeTypeName("pa_seek_mode_t")] pa_seek_mode seek);

        [DllImport(libraryPath, EntryPoint = "pa_stream_write_ext_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_write_ext_free([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr nbytes, [NativeTypeName("pa_free_cb_t")] IntPtr free_cb, [NativeTypeName("void *")] void* free_cb_data, [NativeTypeName("int64_t")] IntPtr offset, [NativeTypeName("pa_seek_mode_t")] pa_seek_mode seek);

        [DllImport(libraryPath, EntryPoint = "pa_stream_peek", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_peek([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] UIntPtr* nbytes);

        [DllImport(libraryPath, EntryPoint = "pa_stream_drop", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_drop([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_writable_size", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr pa_stream_writable_size([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_readable_size", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr pa_stream_readable_size([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_drain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_drain([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_update_timing_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_update_timing_info([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_state_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_state_callback([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_write_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_write_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_request_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_read_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_read_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_request_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_overflow_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_overflow_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_underflow_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int64_t")]
        public static extern IntPtr pa_stream_get_underflow_index([NativeTypeName("pa_stream *")] pa_stream* p);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_underflow_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_underflow_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_started_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_started_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_latency_update_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_latency_update_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_moved_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_moved_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_suspended_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_suspended_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_event_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_event_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_event_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_buffer_attr_callback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_stream_set_buffer_attr_callback([NativeTypeName("pa_stream *")] pa_stream* p, [NativeTypeName("pa_stream_notify_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_cork", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_cork([NativeTypeName("pa_stream *")] pa_stream* s, int b, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_flush", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_flush([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_prebuf", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_prebuf([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_trigger", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_trigger([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_set_name([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_time", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_get_time([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_usec_t *")] UIntPtr* r_usec);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_latency", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_get_latency([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_usec_t *")] UIntPtr* r_usec, [NativeTypeName("int *")] int* negative);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_timing_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const pa_timing_info *")]
        public static extern pa_timing_info* pa_stream_get_timing_info([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_sample_spec", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const pa_sample_spec *")]
        public static extern pa_sample_spec* pa_stream_get_sample_spec([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_channel_map", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const pa_channel_map *")]
        public static extern pa_channel_map* pa_stream_get_channel_map([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_format_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const pa_format_info *")]
        public static extern pa_format_info* pa_stream_get_format_info([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_buffer_attr", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const pa_buffer_attr *")]
        public static extern pa_buffer_attr* pa_stream_get_buffer_attr([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_buffer_attr", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_set_buffer_attr([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_update_sample_rate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_update_sample_rate([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("uint32_t")] uint rate, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_proplist_update", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_proplist_update([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_proplist_remove", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_stream_proplist_remove([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("const char *const []")] sbyte* keys, [NativeTypeName("pa_stream_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_stream_set_monitor_stream", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_stream_set_monitor_stream([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("uint32_t")] uint sink_input_idx);

        [DllImport(libraryPath, EntryPoint = "pa_stream_get_monitor_stream", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint pa_stream_get_monitor_stream([NativeTypeName("pa_stream *")] pa_stream* s);
    }
}
