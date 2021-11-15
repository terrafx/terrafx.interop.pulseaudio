// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sink_info_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sink_info_cb_t")] delegate* unmanaged<pa_context*, pa_sink_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sink_info_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_info_cb_t")] delegate* unmanaged<pa_context*, pa_sink_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sink_info_list(pa_context* c, [NativeTypeName("pa_sink_info_cb_t")] delegate* unmanaged<pa_context*, pa_sink_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_volume_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_volume_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_mute_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_mute_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_suspend_sink_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* sink_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_suspend_sink_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_port_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_port_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_source_info_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_source_info_cb_t")] delegate* unmanaged<pa_context*, pa_source_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_source_info_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_info_cb_t")] delegate* unmanaged<pa_context*, pa_source_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_source_info_list(pa_context* c, [NativeTypeName("pa_source_info_cb_t")] delegate* unmanaged<pa_context*, pa_source_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_volume_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_volume_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_mute_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_mute_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_suspend_source_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* source_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_suspend_source_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_port_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_port_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_server_info(pa_context* c, [NativeTypeName("pa_server_info_cb_t")] delegate* unmanaged<pa_context*, pa_server_info*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_module_info(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_module_info_cb_t")] delegate* unmanaged<pa_context*, pa_module_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_module_info_list(pa_context* c, [NativeTypeName("pa_module_info_cb_t")] delegate* unmanaged<pa_context*, pa_module_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_load_module(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] delegate* unmanaged<pa_context*, uint, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_unload_module(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_client_info(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_client_info_cb_t")] delegate* unmanaged<pa_context*, pa_client_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_client_info_list(pa_context* c, [NativeTypeName("pa_client_info_cb_t")] delegate* unmanaged<pa_context*, pa_client_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_kill_client(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_card_info_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_card_info_cb_t")] delegate* unmanaged<pa_context*, pa_card_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_card_info_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_card_info_cb_t")] delegate* unmanaged<pa_context*, pa_card_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_card_info_list(pa_context* c, [NativeTypeName("pa_card_info_cb_t")] delegate* unmanaged<pa_context*, pa_card_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_card_profile_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_card_profile_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_port_latency_offset(pa_context* c, [NativeTypeName("const char *")] sbyte* card_name, [NativeTypeName("const char *")] sbyte* port_name, [NativeTypeName("int64_t")] nint offset, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sink_input_info(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_input_info_cb_t")] delegate* unmanaged<pa_context*, pa_sink_input_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sink_input_info_list(pa_context* c, [NativeTypeName("pa_sink_input_info_cb_t")] delegate* unmanaged<pa_context*, pa_sink_input_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_move_sink_input_by_name(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* sink_name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_move_sink_input_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint sink_idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_input_volume(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_sink_input_mute(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_kill_sink_input(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_source_output_info(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_output_info_cb_t")] delegate* unmanaged<pa_context*, pa_source_output_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_source_output_info_list(pa_context* c, [NativeTypeName("pa_source_output_info_cb_t")] delegate* unmanaged<pa_context*, pa_source_output_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_move_source_output_by_name(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* source_name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_move_source_output_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint source_idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_output_volume(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_set_source_output_mute(pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_kill_source_output(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_stat(pa_context* c, [NativeTypeName("pa_stat_info_cb_t")] delegate* unmanaged<pa_context*, pa_stat_info*, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sample_info_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sample_info_cb_t")] delegate* unmanaged<pa_context*, pa_sample_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sample_info_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sample_info_cb_t")] delegate* unmanaged<pa_context*, pa_sample_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_sample_info_list(pa_context* c, [NativeTypeName("pa_sample_info_cb_t")] delegate* unmanaged<pa_context*, pa_sample_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_autoload_info_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, pa_autoload_type_t type, [NativeTypeName("pa_autoload_info_cb_t")] delegate* unmanaged<pa_context*, pa_autoload_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_autoload_info_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_autoload_info_cb_t")] delegate* unmanaged<pa_context*, pa_autoload_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_get_autoload_info_list(pa_context* c, [NativeTypeName("pa_autoload_info_cb_t")] delegate* unmanaged<pa_context*, pa_autoload_info*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_add_autoload(pa_context* c, [NativeTypeName("const char *")] sbyte* name, pa_autoload_type_t type, [NativeTypeName("const char *")] sbyte* module, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] delegate* unmanaged<pa_context*, uint, void*, void> param5, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_remove_autoload_by_name(pa_context* c, [NativeTypeName("const char *")] sbyte* name, pa_autoload_type_t type, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_operation* pa_context_remove_autoload_by_index(pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);
    }
}
