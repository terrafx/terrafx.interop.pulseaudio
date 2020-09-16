// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/scache.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_connect_upload([NativeTypeName("pa_stream *")] IntPtr s, [NativeTypeName("size_t")] nuint length);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_finish_upload([NativeTypeName("pa_stream *")] IntPtr s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_remove_sample([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_play_sample([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<IntPtr, int, void*, void> cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_context_play_sample_with_proplist([NativeTypeName("pa_context *")] IntPtr c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("const pa_proplist *")] IntPtr proplist, [NativeTypeName("pa_context_play_sample_cb_t")] delegate* unmanaged<IntPtr, uint, void*, void> cb, [NativeTypeName("void *")] void* userdata);
    }
}
