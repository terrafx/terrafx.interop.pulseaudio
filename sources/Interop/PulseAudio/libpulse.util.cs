using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_get_user_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_user_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(DllName, EntryPoint = "pa_get_host_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_host_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(DllName, EntryPoint = "pa_get_fqdn", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_fqdn([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(DllName, EntryPoint = "pa_get_home_dir", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_home_dir([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(DllName, EntryPoint = "pa_get_binary_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_binary_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(DllName, EntryPoint = "pa_path_get_filename", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_path_get_filename([NativeTypeName("const char *")] sbyte* p);

        [DllImport(DllName, EntryPoint = "pa_msleep", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_msleep([NativeTypeName("unsigned long")] UIntPtr t);
    }
}
