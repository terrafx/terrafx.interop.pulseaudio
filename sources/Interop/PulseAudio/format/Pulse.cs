// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/format.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_encoding_to_string([NativeTypeName("pa_encoding_t")] pa_encoding e);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_encoding_t")]
        public static extern pa_encoding pa_encoding_from_string([NativeTypeName("const char *")] sbyte* encoding);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_new();

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_copy([NativeTypeName("const pa_format_info *")] pa_format_info* src);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_free([NativeTypeName("pa_format_info *")] pa_format_info* f);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_valid([NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_is_pcm([NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_is_compatible([NativeTypeName("const pa_format_info *")] pa_format_info* first, [NativeTypeName("const pa_format_info *")] pa_format_info* second);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_format_info_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_format_info *")] pa_format_info* f);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_from_string([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_format_info *")]
        public static extern pa_format_info* pa_format_info_from_sample_spec([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_to_sample_spec([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern pa_prop_type_t pa_format_info_get_prop_type([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_prop_int([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int *")] int* v);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_prop_int_range([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int *")] int* min, [NativeTypeName("int *")] int* max);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_prop_int_array([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int **")] int** values, [NativeTypeName("int *")] int* n_values);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_prop_string([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("char **")] sbyte** v);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_prop_string_array([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("char ***")] sbyte*** values, [NativeTypeName("int *")] int* n_values);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_free_string_array([NativeTypeName("char **")] sbyte** values, int n_values);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_sample_format([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_sample_format_t *")] pa_sample_format* sf);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_rate([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("uint32_t *")] uint* rate);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_channels([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("uint8_t *")] byte* channels);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_format_info_get_channel_map([NativeTypeName("const pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_prop_int([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, int value);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_prop_int_array([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const int *")] int* values, int n_values);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_prop_int_range([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, int min, int max);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_prop_string([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_prop_string_array([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char **")] sbyte** values, int n_values);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_sample_format([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("pa_sample_format_t")] pa_sample_format sf);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_rate([NativeTypeName("pa_format_info *")] pa_format_info* f, int rate);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_channels([NativeTypeName("pa_format_info *")] pa_format_info* f, int channels);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_format_info_set_channel_map([NativeTypeName("pa_format_info *")] pa_format_info* f, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [NativeTypeName("#define PA_FORMAT_INFO_SNPRINT_MAX 256")]
        public const int PA_FORMAT_INFO_SNPRINT_MAX = 256;
    }
}
