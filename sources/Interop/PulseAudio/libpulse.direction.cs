using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_direction_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_direction_valid([NativeTypeName("pa_direction_t")] pa_direction direction);

        [DllImport(DllName, EntryPoint = "pa_direction_to_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_direction_to_string([NativeTypeName("pa_direction_t")] pa_direction direction);
    }
}
