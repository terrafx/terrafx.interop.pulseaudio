// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_mainloop_api_once([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* m, [NativeTypeName("void (*)(pa_mainloop_api *, void *)")] delegate* unmanaged<pa_mainloop_api*, void*, void> callback, [NativeTypeName("void *")] void* userdata);
    }
}
