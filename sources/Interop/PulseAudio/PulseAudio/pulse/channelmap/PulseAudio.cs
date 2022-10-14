// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/channelmap.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_init(pa_channel_map* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_init_mono(pa_channel_map* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_init_stereo(pa_channel_map* m);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_init_auto(pa_channel_map* m, [NativeTypeName("unsigned int")] uint channels, pa_channel_map_def_t def);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_init_extend(pa_channel_map* m, [NativeTypeName("unsigned int")] uint channels, pa_channel_map_def_t def);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_channel_position_to_string(pa_channel_position_t pos);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_position_t pa_channel_position_from_string([NativeTypeName("const char *")] sbyte* s);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_channel_position_to_pretty_string(pa_channel_position_t pos);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* pa_channel_map_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_channel_map* pa_channel_map_parse(pa_channel_map* map, [NativeTypeName("const char *")] sbyte* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_equal([NativeTypeName("const pa_channel_map *")] pa_channel_map* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_valid([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_compatible([NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_superset([NativeTypeName("const pa_channel_map *")] pa_channel_map* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* b);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_can_balance([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_can_fade([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_can_lfe_balance([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_channel_map_to_name([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_channel_map_to_pretty_name([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_channel_map_has_position([NativeTypeName("const pa_channel_map *")] pa_channel_map* map, pa_channel_position_t p);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_channel_position_mask_t")]
    public static extern nuint pa_channel_map_mask([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

    [NativeTypeName("#define PA_CHANNEL_MAP_SNPRINT_MAX 336")]
    public const int PA_CHANNEL_MAP_SNPRINT_MAX = 336;
}
