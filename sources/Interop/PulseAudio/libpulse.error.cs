using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_strerror", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_strerror(int error);
    }
}
