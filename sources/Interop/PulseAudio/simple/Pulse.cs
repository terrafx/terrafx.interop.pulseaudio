// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/simple.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(LibraryPath, EntryPoint = "pa_simple_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_simple *")]
        public static extern pa_simple* pa_simple_new([NativeTypeName("const char *")] sbyte* server, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_stream_direction_t")] pa_stream_direction dir, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const char *")] sbyte* stream_name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, [NativeTypeName("int *")] int* error);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_simple_free([NativeTypeName("pa_simple *")] pa_simple* s);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_write", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_simple_write([NativeTypeName("pa_simple *")] pa_simple* s, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr bytes, [NativeTypeName("int *")] int* error);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_drain", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_simple_drain([NativeTypeName("pa_simple *")] pa_simple* s, [NativeTypeName("int *")] int* error);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_read", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_simple_read([NativeTypeName("pa_simple *")] pa_simple* s, [NativeTypeName("void *")] void* data, [NativeTypeName("size_t")] UIntPtr bytes, [NativeTypeName("int *")] int* error);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_get_latency", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_simple_get_latency([NativeTypeName("pa_simple *")] pa_simple* s, [NativeTypeName("int *")] int* error);

        [DllImport(LibraryPath, EntryPoint = "pa_simple_flush", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_simple_flush([NativeTypeName("pa_simple *")] pa_simple* s, [NativeTypeName("int *")] int* error);
    }
}
