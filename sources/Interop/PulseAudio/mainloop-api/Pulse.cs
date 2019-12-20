// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop-api.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(LibraryPath, EntryPoint = "pa_mainloop_api_once", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_mainloop_api_once([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* m, [NativeTypeName("void (*)(pa_mainloop_api *, void *)")] IntPtr callback, [NativeTypeName("void *")] void* userdata);
    }
}
