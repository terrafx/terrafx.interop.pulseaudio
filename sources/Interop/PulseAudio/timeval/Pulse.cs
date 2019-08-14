// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/timeval.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_gettimeofday", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_gettimeofday([NativeTypeName("struct timeval *")] timeval* tv);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_diff", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_timeval_diff([NativeTypeName("const struct timeval *")] timeval* a, [NativeTypeName("const struct timeval *")] timeval* b);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_cmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_timeval_cmp([NativeTypeName("const struct timeval *")] timeval* a, [NativeTypeName("const struct timeval *")] timeval* b);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_age", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_timeval_age([NativeTypeName("const struct timeval *")] timeval* tv);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_add", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_add([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] UIntPtr v);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_sub", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_sub([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] UIntPtr v);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_store", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_store([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] UIntPtr v);

        [DllImport(libraryPath, EntryPoint = "pa_timeval_load", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_timeval_load([NativeTypeName("const struct timeval *")] timeval* tv);
    }
}
