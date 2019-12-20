// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_mainloop *")]
        public static extern pa_mainloop* pa_mainloop_new();

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_mainloop_free([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_prepare", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_prepare([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int timeout);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_poll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_poll([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_dispatch", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_dispatch([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_get_retval", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_get_retval([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_iterate", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_iterate([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int block, [NativeTypeName("int *")] int* retval);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_run", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_mainloop_run([NativeTypeName("pa_mainloop *")] pa_mainloop* m, [NativeTypeName("int *")] int* retval);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_get_api", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_mainloop_api *")]
        public static extern pa_mainloop_api* pa_mainloop_get_api([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_quit", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_mainloop_quit([NativeTypeName("pa_mainloop *")] pa_mainloop* m, int retval);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_wakeup", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_mainloop_wakeup([NativeTypeName("pa_mainloop *")] pa_mainloop* m);

        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_set_poll_func", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_mainloop_set_poll_func([NativeTypeName("pa_mainloop *")] pa_mainloop* m, [NativeTypeName("pa_poll_func")] IntPtr poll_func, [NativeTypeName("void *")] void* userdata);
    }
}
