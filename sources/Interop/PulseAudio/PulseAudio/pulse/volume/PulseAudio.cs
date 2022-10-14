// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/volume.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_cvolume_equal([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_init(pa_cvolume* a);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_set(pa_cvolume* a, [NativeTypeName("unsigned int")] uint channels, [NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_cvolume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_sw_cvolume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_cvolume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, int print_dB);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_volume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_sw_volume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_volume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v, int print_dB);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_avg([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_avg_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_max([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_max_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_min([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_min_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_cvolume_valid([NativeTypeName("const pa_cvolume *")] pa_cvolume* v);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_cvolume_channels_equal_to([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_sw_volume_multiply([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_sw_cvolume_multiply(pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_sw_cvolume_multiply_scalar(pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_sw_volume_divide([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_sw_cvolume_divide(pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_sw_cvolume_divide_scalar(pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_sw_volume_from_dB(double f);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern double pa_sw_volume_to_dB([NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_sw_volume_from_linear(double v);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern double pa_sw_volume_to_linear([NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_remap(pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* from, [NativeTypeName("const pa_channel_map *")] pa_channel_map* to);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_cvolume_compatible([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_cvolume_compatible_with_channel_map([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern float pa_cvolume_get_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_set_balance(pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern float pa_cvolume_get_fade([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_set_fade(pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_fade);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern float pa_cvolume_get_lfe_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_set_lfe_balance(pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_scale(pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_scale_mask(pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_set_position(pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, pa_channel_position_t t, [NativeTypeName("pa_volume_t")] uint v);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_volume_t")]
    public static extern uint pa_cvolume_get_position([NativeTypeName("const pa_cvolume *")] pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, pa_channel_position_t t);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_merge(pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_inc_clamp(pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc, [NativeTypeName("pa_volume_t")] uint limit);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_inc(pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_cvolume* pa_cvolume_dec(pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint dec);

    [NativeTypeName("#define PA_VOLUME_NORM ((pa_volume_t) 0x10000U)")]
    public const uint PA_VOLUME_NORM = ((uint)(0x10000U));

    [NativeTypeName("#define PA_VOLUME_MUTED ((pa_volume_t) 0U)")]
    public const uint PA_VOLUME_MUTED = ((uint)(0U));

    [NativeTypeName("#define PA_VOLUME_MAX ((pa_volume_t) UINT32_MAX/2)")]
    public const uint PA_VOLUME_MAX = ((uint)(4294967295U) / 2);

    [NativeTypeName("#define PA_VOLUME_UI_MAX (pa_sw_volume_from_dB(+11.0))")]
    public static uint PA_VOLUME_UI_MAX => (pa_sw_volume_from_dB(+11.0));

    [NativeTypeName("#define PA_VOLUME_INVALID ((pa_volume_t) UINT32_MAX)")]
    public const uint PA_VOLUME_INVALID = ((uint)(4294967295U));

    [NativeTypeName("#define PA_CVOLUME_SNPRINT_MAX 320")]
    public const int PA_CVOLUME_SNPRINT_MAX = 320;

    [NativeTypeName("#define PA_SW_CVOLUME_SNPRINT_DB_MAX 448")]
    public const int PA_SW_CVOLUME_SNPRINT_DB_MAX = 448;

    [NativeTypeName("#define PA_CVOLUME_SNPRINT_VERBOSE_MAX 1984")]
    public const int PA_CVOLUME_SNPRINT_VERBOSE_MAX = 1984;

    [NativeTypeName("#define PA_VOLUME_SNPRINT_MAX 10")]
    public const int PA_VOLUME_SNPRINT_MAX = 10;

    [NativeTypeName("#define PA_SW_VOLUME_SNPRINT_DB_MAX 11")]
    public const int PA_SW_VOLUME_SNPRINT_DB_MAX = 11;

    [NativeTypeName("#define PA_VOLUME_SNPRINT_VERBOSE_MAX 35")]
    public const int PA_VOLUME_SNPRINT_VERBOSE_MAX = 35;

    [NativeTypeName("#define PA_DECIBEL_MININFTY ((double) -200.0)")]
    public const double PA_DECIBEL_MININFTY = ((double)(-200.0));
}
