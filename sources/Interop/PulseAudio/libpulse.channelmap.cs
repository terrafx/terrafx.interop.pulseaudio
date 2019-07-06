using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public enum pa_channel_position
    {
        PA_CHANNEL_POSITION_INVALID = -1,
        PA_CHANNEL_POSITION_MONO = 0,
        PA_CHANNEL_POSITION_FRONT_LEFT,
        PA_CHANNEL_POSITION_FRONT_RIGHT,
        PA_CHANNEL_POSITION_FRONT_CENTER,
        PA_CHANNEL_POSITION_LEFT = PA_CHANNEL_POSITION_FRONT_LEFT,
        PA_CHANNEL_POSITION_RIGHT = PA_CHANNEL_POSITION_FRONT_RIGHT,
        PA_CHANNEL_POSITION_CENTER = PA_CHANNEL_POSITION_FRONT_CENTER,
        PA_CHANNEL_POSITION_REAR_CENTER,
        PA_CHANNEL_POSITION_REAR_LEFT,
        PA_CHANNEL_POSITION_REAR_RIGHT,
        PA_CHANNEL_POSITION_LFE,
        PA_CHANNEL_POSITION_SUBWOOFER = PA_CHANNEL_POSITION_LFE,
        PA_CHANNEL_POSITION_FRONT_LEFT_OF_CENTER,
        PA_CHANNEL_POSITION_FRONT_RIGHT_OF_CENTER,
        PA_CHANNEL_POSITION_SIDE_LEFT,
        PA_CHANNEL_POSITION_SIDE_RIGHT,
        PA_CHANNEL_POSITION_AUX0,
        PA_CHANNEL_POSITION_AUX1,
        PA_CHANNEL_POSITION_AUX2,
        PA_CHANNEL_POSITION_AUX3,
        PA_CHANNEL_POSITION_AUX4,
        PA_CHANNEL_POSITION_AUX5,
        PA_CHANNEL_POSITION_AUX6,
        PA_CHANNEL_POSITION_AUX7,
        PA_CHANNEL_POSITION_AUX8,
        PA_CHANNEL_POSITION_AUX9,
        PA_CHANNEL_POSITION_AUX10,
        PA_CHANNEL_POSITION_AUX11,
        PA_CHANNEL_POSITION_AUX12,
        PA_CHANNEL_POSITION_AUX13,
        PA_CHANNEL_POSITION_AUX14,
        PA_CHANNEL_POSITION_AUX15,
        PA_CHANNEL_POSITION_AUX16,
        PA_CHANNEL_POSITION_AUX17,
        PA_CHANNEL_POSITION_AUX18,
        PA_CHANNEL_POSITION_AUX19,
        PA_CHANNEL_POSITION_AUX20,
        PA_CHANNEL_POSITION_AUX21,
        PA_CHANNEL_POSITION_AUX22,
        PA_CHANNEL_POSITION_AUX23,
        PA_CHANNEL_POSITION_AUX24,
        PA_CHANNEL_POSITION_AUX25,
        PA_CHANNEL_POSITION_AUX26,
        PA_CHANNEL_POSITION_AUX27,
        PA_CHANNEL_POSITION_AUX28,
        PA_CHANNEL_POSITION_AUX29,
        PA_CHANNEL_POSITION_AUX30,
        PA_CHANNEL_POSITION_AUX31,
        PA_CHANNEL_POSITION_TOP_CENTER,
        PA_CHANNEL_POSITION_TOP_FRONT_LEFT,
        PA_CHANNEL_POSITION_TOP_FRONT_RIGHT,
        PA_CHANNEL_POSITION_TOP_FRONT_CENTER,
        PA_CHANNEL_POSITION_TOP_REAR_LEFT,
        PA_CHANNEL_POSITION_TOP_REAR_RIGHT,
        PA_CHANNEL_POSITION_TOP_REAR_CENTER,
        PA_CHANNEL_POSITION_MAX,
    }

    public enum pa_channel_map_def : uint
    {
        PA_CHANNEL_MAP_AIFF,
        PA_CHANNEL_MAP_ALSA,
        PA_CHANNEL_MAP_AUX,
        PA_CHANNEL_MAP_WAVEEX,
        PA_CHANNEL_MAP_OSS,
        PA_CHANNEL_MAP_DEF_MAX,
        PA_CHANNEL_MAP_DEFAULT = PA_CHANNEL_MAP_AIFF,
    }

    public partial struct pa_channel_map
    {
        [NativeTypeName("uint8_t")]
        public byte channels;

        [NativeTypeName("pa_channel_position_t [32]")]
        public _map_e__FixedBuffer map;

        public partial struct _map_e__FixedBuffer
        {
            internal pa_channel_position e0;
            internal pa_channel_position e1;
            internal pa_channel_position e2;
            internal pa_channel_position e3;
            internal pa_channel_position e4;
            internal pa_channel_position e5;
            internal pa_channel_position e6;
            internal pa_channel_position e7;
            internal pa_channel_position e8;
            internal pa_channel_position e9;
            internal pa_channel_position e10;
            internal pa_channel_position e11;
            internal pa_channel_position e12;
            internal pa_channel_position e13;
            internal pa_channel_position e14;
            internal pa_channel_position e15;
            internal pa_channel_position e16;
            internal pa_channel_position e17;
            internal pa_channel_position e18;
            internal pa_channel_position e19;
            internal pa_channel_position e20;
            internal pa_channel_position e21;
            internal pa_channel_position e22;
            internal pa_channel_position e23;
            internal pa_channel_position e24;
            internal pa_channel_position e25;
            internal pa_channel_position e26;
            internal pa_channel_position e27;
            internal pa_channel_position e28;
            internal pa_channel_position e29;
            internal pa_channel_position e30;
            internal pa_channel_position e31;

            public unsafe ref pa_channel_position this[int index]
            {
                get
                {
                    fixed (pa_channel_position* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_channel_map_init", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_init([NativeTypeName("pa_channel_map *")] pa_channel_map* m);

        [DllImport(DllName, EntryPoint = "pa_channel_map_init_mono", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_init_mono([NativeTypeName("pa_channel_map *")] pa_channel_map* m);

        [DllImport(DllName, EntryPoint = "pa_channel_map_init_stereo", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_init_stereo([NativeTypeName("pa_channel_map *")] pa_channel_map* m);

        [DllImport(DllName, EntryPoint = "pa_channel_map_init_auto", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_init_auto([NativeTypeName("pa_channel_map *")] pa_channel_map* m, [NativeTypeName("unsigned int")] uint channels, [NativeTypeName("pa_channel_map_def_t")] pa_channel_map_def def);

        [DllImport(DllName, EntryPoint = "pa_channel_map_init_extend", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_init_extend([NativeTypeName("pa_channel_map *")] pa_channel_map* m, [NativeTypeName("unsigned int")] uint channels, [NativeTypeName("pa_channel_map_def_t")] pa_channel_map_def def);

        [DllImport(DllName, EntryPoint = "pa_channel_position_to_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_channel_position_to_string([NativeTypeName("pa_channel_position_t")] pa_channel_position pos);

        [DllImport(DllName, EntryPoint = "pa_channel_position_from_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_position_t")]
        public static extern pa_channel_position pa_channel_position_from_string([NativeTypeName("const char *")] sbyte* s);

        [DllImport(DllName, EntryPoint = "pa_channel_position_to_pretty_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_channel_position_to_pretty_string([NativeTypeName("pa_channel_position_t")] pa_channel_position pos);

        [DllImport(DllName, EntryPoint = "pa_channel_map_snprint", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_channel_map_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_parse", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_map *")]
        public static extern pa_channel_map* pa_channel_map_parse([NativeTypeName("pa_channel_map *")] pa_channel_map* map, [NativeTypeName("const char *")] sbyte* s);

        [DllImport(DllName, EntryPoint = "pa_channel_map_equal", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_equal([NativeTypeName("const pa_channel_map *")] pa_channel_map* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* b);

        [DllImport(DllName, EntryPoint = "pa_channel_map_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_valid([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_compatible", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_compatible([NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport(DllName, EntryPoint = "pa_channel_map_superset", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_superset([NativeTypeName("const pa_channel_map *")] pa_channel_map* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* b);

        [DllImport(DllName, EntryPoint = "pa_channel_map_can_balance", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_can_balance([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_can_fade", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_can_fade([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_can_lfe_balance", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_can_lfe_balance([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_to_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_channel_map_to_name([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_to_pretty_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_channel_map_to_pretty_name([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport(DllName, EntryPoint = "pa_channel_map_has_position", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_channel_map_has_position([NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_channel_position_t")] pa_channel_position p);

        [DllImport(DllName, EntryPoint = "pa_channel_map_mask", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_channel_position_mask_t")]
        public static extern UIntPtr pa_channel_map_mask([NativeTypeName("const pa_channel_map *")] pa_channel_map* map);
    }
}
