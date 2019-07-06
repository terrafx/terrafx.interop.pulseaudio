using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_cvolume
    {
        [NativeTypeName("uint8_t")]
        public byte channels;

        [NativeTypeName("pa_volume_t [32]")]
        public fixed uint values[32];
    }

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_cvolume_equal", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_cvolume_equal([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport(DllName, EntryPoint = "pa_cvolume_init", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_init([NativeTypeName("pa_cvolume *")] pa_cvolume* a);

        [DllImport(DllName, EntryPoint = "pa_cvolume_set", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set([NativeTypeName("pa_cvolume *")] pa_cvolume* a, [NativeTypeName("unsigned int")] uint channels, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_cvolume_snprint", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_cvolume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

        [DllImport(DllName, EntryPoint = "pa_sw_cvolume_snprint_dB", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_sw_cvolume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

        [DllImport(DllName, EntryPoint = "pa_cvolume_snprint_verbose", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_cvolume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, int print_dB);

        [DllImport(DllName, EntryPoint = "pa_volume_snprint", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_volume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_snprint_dB", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_sw_volume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_volume_snprint_verbose", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_volume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("pa_volume_t")] uint v, int print_dB);

        [DllImport(DllName, EntryPoint = "pa_cvolume_avg", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_avg([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport(DllName, EntryPoint = "pa_cvolume_avg_mask", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_avg_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] UIntPtr mask);

        [DllImport(DllName, EntryPoint = "pa_cvolume_max", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_max([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport(DllName, EntryPoint = "pa_cvolume_max_mask", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_max_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] UIntPtr mask);

        [DllImport(DllName, EntryPoint = "pa_cvolume_min", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_min([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport(DllName, EntryPoint = "pa_cvolume_min_mask", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_min_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] UIntPtr mask);

        [DllImport(DllName, EntryPoint = "pa_cvolume_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_cvolume_valid([NativeTypeName("const pa_cvolume *")] pa_cvolume* v);

        [DllImport(DllName, EntryPoint = "pa_cvolume_channels_equal_to", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_cvolume_channels_equal_to([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_multiply", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_multiply([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport(DllName, EntryPoint = "pa_sw_cvolume_multiply", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_multiply([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport(DllName, EntryPoint = "pa_sw_cvolume_multiply_scalar", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_multiply_scalar([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_divide", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_divide([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport(DllName, EntryPoint = "pa_sw_cvolume_divide", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_divide([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport(DllName, EntryPoint = "pa_sw_cvolume_divide_scalar", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_divide_scalar([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_from_dB", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_from_dB(double f);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_to_dB", CallingConvention = CallingConvention.Cdecl)]
        public static extern double pa_sw_volume_to_dB([NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_from_linear", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_from_linear(double v);

        [DllImport(DllName, EntryPoint = "pa_sw_volume_to_linear", CallingConvention = CallingConvention.Cdecl)]
        public static extern double pa_sw_volume_to_linear([NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_cvolume_remap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_remap([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* from, [NativeTypeName("const pa_channel_map *")] pa_channel_map* to);

        [DllImport(DllName, EntryPoint = "pa_cvolume_compatible", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_cvolume_compatible([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport(DllName, EntryPoint = "pa_cvolume_compatible_with_channel_map", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_cvolume_compatible_with_channel_map([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm);

        [DllImport(DllName, EntryPoint = "pa_cvolume_get_balance", CallingConvention = CallingConvention.Cdecl)]
        public static extern float pa_cvolume_get_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_cvolume_set_balance", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_balance([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

        [DllImport(DllName, EntryPoint = "pa_cvolume_get_fade", CallingConvention = CallingConvention.Cdecl)]
        public static extern float pa_cvolume_get_fade([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_cvolume_set_fade", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_fade([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_fade);

        [DllImport(DllName, EntryPoint = "pa_cvolume_get_lfe_balance", CallingConvention = CallingConvention.Cdecl)]
        public static extern float pa_cvolume_get_lfe_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_cvolume_set_lfe_balance", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_lfe_balance([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

        [DllImport(DllName, EntryPoint = "pa_cvolume_scale", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_scale([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max);

        [DllImport(DllName, EntryPoint = "pa_cvolume_scale_mask", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_scale_mask([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] UIntPtr mask);

        [DllImport(DllName, EntryPoint = "pa_cvolume_set_position", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_position([NativeTypeName("pa_cvolume *")] pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_channel_position_t")] pa_channel_position t, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport(DllName, EntryPoint = "pa_cvolume_get_position", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_get_position([NativeTypeName("pa_cvolume *")] pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_channel_position_t")] pa_channel_position t);

        [DllImport(DllName, EntryPoint = "pa_cvolume_merge", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_merge([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport(DllName, EntryPoint = "pa_cvolume_inc_clamp", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_inc_clamp([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc, [NativeTypeName("pa_volume_t")] uint limit);

        [DllImport(DllName, EntryPoint = "pa_cvolume_inc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_inc([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc);

        [DllImport(DllName, EntryPoint = "pa_cvolume_dec", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_dec([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint dec);
    }
}
