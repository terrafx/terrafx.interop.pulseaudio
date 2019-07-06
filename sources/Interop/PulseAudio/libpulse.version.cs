using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_get_library_version", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_get_library_version();
    }
}
