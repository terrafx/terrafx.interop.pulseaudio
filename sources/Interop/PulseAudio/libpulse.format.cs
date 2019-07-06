using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public enum pa_encoding
    {
        PA_ENCODING_ANY,
        PA_ENCODING_PCM,
        PA_ENCODING_AC3_IEC61937,
        PA_ENCODING_EAC3_IEC61937,
        PA_ENCODING_MPEG_IEC61937,
        PA_ENCODING_DTS_IEC61937,
        PA_ENCODING_MPEG2_AAC_IEC61937,
        PA_ENCODING_MAX,
        PA_ENCODING_INVALID = -1,
    }

    public unsafe partial struct pa_format_info
    {
        [NativeTypeName("pa_encoding_t")]
        public pa_encoding encoding;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* plist;
    }

    public enum pa_prop_type_t
    {
        PA_PROP_TYPE_INT,
        PA_PROP_TYPE_INT_RANGE,
        PA_PROP_TYPE_INT_ARRAY,
        PA_PROP_TYPE_STRING,
        PA_PROP_TYPE_STRING_ARRAY,
        PA_PROP_TYPE_INVALID = -1,
    }

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_encoding_to_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_encoding_to_string([NativeTypeName("pa_encoding_t")] pa_encoding e);

        [DllImport(DllName, EntryPoint = "pa_encoding_from_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_encoding_t")]
        public static extern pa_encoding pa_encoding_from_string([NativeTypeName("const char *")] sbyte* encoding);

        [DllImport(DllName, EntryPoint = "pa_format_info_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_new();

        [DllImport(DllName, EntryPoint = "pa_format_info_copy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_copy([NativeTypeName("const pa_format_info *")] pa_format_info* src);

        [DllImport(DllName, EntryPoint = "pa_format_info_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_free([NativeTypeName("pa_format_info *")] pa_format_info* f);

        [DllImport(DllName, EntryPoint = "pa_format_info_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_valid([NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport(DllName, EntryPoint = "pa_format_info_is_pcm", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_is_pcm([NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport(DllName, EntryPoint = "pa_format_info_is_compatible", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_is_compatible([NativeTypeName("const pa_format_info *")] pa_format_info* first, [NativeTypeName("const pa_format_info *")] pa_format_info* second);

        [DllImport(DllName, EntryPoint = "pa_format_info_snprint", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_format_info_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport(DllName, EntryPoint = "pa_format_info_from_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_from_string([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_format_info_from_sample_spec", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_from_sample_spec([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_format_info_to_sample_spec", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_to_sample_spec([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern pa_prop_type_t pa_format_info_get_prop_type([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_get_prop_int([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int *")] int* v);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_int_range", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_get_prop_int_range([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int *")] int* min, [NativeTypeName("int *")] int* max);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_int_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_get_prop_int_array([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int **")] int** values, [NativeTypeName("int *")] int* n_values);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_get_prop_string([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("char **")] sbyte** v);

        [DllImport(DllName, EntryPoint = "pa_format_info_get_prop_string_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_format_info_get_prop_string_array([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("char ***")] sbyte*** values, [NativeTypeName("int *")] int* n_values);

        [DllImport(DllName, EntryPoint = "pa_format_info_free_string_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_free_string_array([NativeTypeName("char **")] sbyte** values, int n_values);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_prop_int", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_prop_int([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, int value);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_prop_int_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_prop_int_array([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const int *")] int* values, int n_values);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_prop_int_range", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_prop_int_range([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, int min, int max);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_prop_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_prop_string([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_prop_string_array", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_prop_string_array([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char **")] sbyte** values, int n_values);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_sample_format", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_sample_format([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_sample_format_t")] pa_sample_format sf);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_rate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_rate([NativeTypeName("pa_format_info *")] pa_format_info* f, int rate);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_channels", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_channels([NativeTypeName("pa_format_info *")] pa_format_info* f, int channels);

        [DllImport(DllName, EntryPoint = "pa_format_info_set_channel_map", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_format_info_set_channel_map([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);
    }
}
