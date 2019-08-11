// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/util.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_get_user_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_user_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(libraryPath, EntryPoint = "pa_get_host_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_host_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(libraryPath, EntryPoint = "pa_get_fqdn", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_fqdn([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(libraryPath, EntryPoint = "pa_get_home_dir", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_home_dir([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(libraryPath, EntryPoint = "pa_get_binary_name", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_binary_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] UIntPtr l);

        [DllImport(libraryPath, EntryPoint = "pa_path_get_filename", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_path_get_filename([NativeTypeName("const char *")] sbyte* p);

        [DllImport(libraryPath, EntryPoint = "pa_msleep", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_msleep([NativeTypeName("unsigned long")] UIntPtr t);
    }
}
