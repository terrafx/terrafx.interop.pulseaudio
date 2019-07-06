using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_sink_port_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint priority;

        public int available;
    }

    public unsafe partial struct pa_sink_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* description;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        public pa_cvolume volume;

        public int mute;

        [NativeTypeName("uint32_t")]
        public uint monitor_source;

        [NativeTypeName("const char *")]
        public sbyte* monitor_source_name;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr latency;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_sink_flags_t")]
        public pa_sink_flags flags;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_latency;

        [NativeTypeName("pa_volume_t")]
        public uint base_volume;

        [NativeTypeName("pa_sink_state_t")]
        public pa_sink_state state;

        [NativeTypeName("uint32_t")]
        public uint n_volume_steps;

        [NativeTypeName("uint32_t")]
        public uint card;

        [NativeTypeName("uint32_t")]
        public uint n_ports;

        [NativeTypeName("pa_sink_port_info **")]
        public pa_sink_port_info** ports;

        [NativeTypeName("pa_sink_port_info *")]
        public pa_sink_port_info* active_port;

        [NativeTypeName("uint8_t")]
        public byte n_formats;

        [NativeTypeName("pa_format_info **")]
        public pa_format_info** formats;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_sink_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_sink_info *")] pa_sink_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_source_port_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint priority;

        public int available;
    }

    public unsafe partial struct pa_source_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* description;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        public pa_cvolume volume;

        public int mute;

        [NativeTypeName("uint32_t")]
        public uint monitor_of_sink;

        [NativeTypeName("const char *")]
        public sbyte* monitor_of_sink_name;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr latency;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_source_flags_t")]
        public pa_source_flags flags;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_latency;

        [NativeTypeName("pa_volume_t")]
        public uint base_volume;

        [NativeTypeName("pa_source_state_t")]
        public pa_source_state state;

        [NativeTypeName("uint32_t")]
        public uint n_volume_steps;

        [NativeTypeName("uint32_t")]
        public uint card;

        [NativeTypeName("uint32_t")]
        public uint n_ports;

        [NativeTypeName("pa_source_port_info **")]
        public pa_source_port_info** ports;

        [NativeTypeName("pa_source_port_info *")]
        public pa_source_port_info* active_port;

        [NativeTypeName("uint8_t")]
        public byte n_formats;

        [NativeTypeName("pa_format_info **")]
        public pa_format_info** formats;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_source_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_source_info *")] pa_source_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_server_info
    {
        [NativeTypeName("const char *")]
        public sbyte* user_name;

        [NativeTypeName("const char *")]
        public sbyte* host_name;

        [NativeTypeName("const char *")]
        public sbyte* server_version;

        [NativeTypeName("const char *")]
        public sbyte* server_name;

        public pa_sample_spec sample_spec;

        [NativeTypeName("const char *")]
        public sbyte* default_sink_name;

        [NativeTypeName("const char *")]
        public sbyte* default_source_name;

        [NativeTypeName("uint32_t")]
        public uint cookie;

        public pa_channel_map channel_map;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_server_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_server_info *")] pa_server_info* i, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_module_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* argument;

        [NativeTypeName("uint32_t")]
        public uint n_used;

        public int auto_unload;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_module_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_module_info *")] pa_module_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_index_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_client_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_client_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_client_info *")] pa_client_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_card_profile_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint n_sinks;

        [NativeTypeName("uint32_t")]
        public uint n_sources;

        [NativeTypeName("uint32_t")]
        public uint priority;
    }

    public unsafe partial struct pa_card_profile_info2
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint n_sinks;

        [NativeTypeName("uint32_t")]
        public uint n_sources;

        [NativeTypeName("uint32_t")]
        public uint priority;

        public int available;
    }

    public unsafe partial struct pa_card_port_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint priority;

        public int available;

        public int direction;

        [NativeTypeName("uint32_t")]
        public uint n_profiles;

        [NativeTypeName("pa_card_profile_info **")]
        public pa_card_profile_info** profiles;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        [NativeTypeName("int64_t")]
        public IntPtr latency_offset;

        [NativeTypeName("pa_card_profile_info2 **")]
        public pa_card_profile_info2** profiles2;
    }

    public unsafe partial struct pa_card_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("uint32_t")]
        public uint n_profiles;

        [NativeTypeName("pa_card_profile_info *")]
        public pa_card_profile_info* profiles;

        [NativeTypeName("pa_card_profile_info *")]
        public pa_card_profile_info* active_profile;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        [NativeTypeName("uint32_t")]
        public uint n_ports;

        [NativeTypeName("pa_card_port_info **")]
        public pa_card_port_info** ports;

        [NativeTypeName("pa_card_profile_info2 **")]
        public pa_card_profile_info2** profiles2;

        [NativeTypeName("pa_card_profile_info2 *")]
        public pa_card_profile_info2* active_profile2;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_card_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_card_info *")] pa_card_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_sink_input_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        [NativeTypeName("uint32_t")]
        public uint client;

        [NativeTypeName("uint32_t")]
        public uint sink;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        public pa_cvolume volume;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr buffer_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr sink_usec;

        [NativeTypeName("const char *")]
        public sbyte* resample_method;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        public int mute;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        public int corked;

        public int has_volume;

        public int volume_writable;

        [NativeTypeName("pa_format_info *")]
        public pa_format_info* format;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_sink_input_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_sink_input_info *")] pa_sink_input_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_source_output_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        [NativeTypeName("uint32_t")]
        public uint client;

        [NativeTypeName("uint32_t")]
        public uint source;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr buffer_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr source_usec;

        [NativeTypeName("const char *")]
        public sbyte* resample_method;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        public int corked;

        public pa_cvolume volume;

        public int mute;

        public int has_volume;

        public int volume_writable;

        [NativeTypeName("pa_format_info *")]
        public pa_format_info* format;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_source_output_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_source_output_info *")] pa_source_output_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public partial struct pa_stat_info
    {
        [NativeTypeName("uint32_t")]
        public uint memblock_total;

        [NativeTypeName("uint32_t")]
        public uint memblock_total_size;

        [NativeTypeName("uint32_t")]
        public uint memblock_allocated;

        [NativeTypeName("uint32_t")]
        public uint memblock_allocated_size;

        [NativeTypeName("uint32_t")]
        public uint scache_size;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_stat_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_stat_info *")] pa_stat_info* i, [NativeTypeName("void *")] void* userdata);

    public unsafe partial struct pa_sample_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        public pa_cvolume volume;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr duration;

        [NativeTypeName("uint32_t")]
        public uint bytes;

        public int lazy;

        [NativeTypeName("const char *")]
        public sbyte* filename;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_sample_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_sample_info *")] pa_sample_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public enum pa_autoload_type : uint
    {
        PA_AUTOLOAD_SINK = 0,
        PA_AUTOLOAD_SOURCE = 1,
    }

    public unsafe partial struct pa_autoload_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("pa_autoload_type_t")]
        public pa_autoload_type type;

        [NativeTypeName("const char *")]
        public sbyte* module;

        [NativeTypeName("const char *")]
        public sbyte* argument;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_autoload_info_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const pa_autoload_info *")] pa_autoload_info* i, int eol, [NativeTypeName("void *")] void* userdata);

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_context_get_sink_info_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sink_info_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sink_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_volume_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_volume_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_volume_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_volume_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_mute_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_mute_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_mute_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_mute_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_suspend_sink_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_sink_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* sink_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_suspend_sink_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_sink_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_port_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_port_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_port_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_port_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_source_info_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_source_info_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_source_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_volume_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_volume_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_volume_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_volume_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_mute_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_mute_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_mute_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_mute_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_suspend_source_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_source_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* source_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_suspend_source_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_source_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_port_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_port_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_port_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_port_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_server_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_server_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_server_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_module_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_module_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_module_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_module_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_module_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_module_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_load_module", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_load_module([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_unload_module", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_unload_module([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_client_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_client_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_client_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_client_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_client_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_client_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_kill_client", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_client([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_card_info_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_card_info_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_card_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_card_profile_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_card_profile_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_card_profile_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_card_profile_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_port_latency_offset", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_port_latency_offset([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* card_name, [NativeTypeName("const char *")] sbyte* port_name, [NativeTypeName("int64_t")] IntPtr offset, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sink_input_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_input_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_input_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sink_input_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_input_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sink_input_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_move_sink_input_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_sink_input_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* sink_name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_move_sink_input_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_sink_input_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint sink_idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_input_volume", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_input_volume([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_sink_input_mute", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_input_mute([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_kill_sink_input", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_sink_input([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_source_output_info", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_output_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_output_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_source_output_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_output_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_source_output_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_move_source_output_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_source_output_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* source_name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_move_source_output_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_source_output_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint source_idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_output_volume", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_output_volume([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_set_source_output_mute", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_output_mute([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_kill_source_output", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_source_output([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_stat", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_stat([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_stat_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sample_info_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sample_info_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_sample_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_autoload_info_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_autoload_info_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_get_autoload_info_list", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_add_autoload", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_add_autoload([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("const char *")] sbyte* module, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] IntPtr param5, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_remove_autoload_by_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_autoload_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(DllName, EntryPoint = "pa_context_remove_autoload_by_index", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_autoload_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
