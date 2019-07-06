using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_utf8_valid", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_valid([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_ascii_valid", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_ascii_valid([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_utf8_filter", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_filter([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_ascii_filter", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_ascii_filter([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_utf8_to_locale", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_to_locale([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_locale_to_utf8", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_locale_to_utf8([NativeTypeName("const char *")] sbyte* str);
    }
}
