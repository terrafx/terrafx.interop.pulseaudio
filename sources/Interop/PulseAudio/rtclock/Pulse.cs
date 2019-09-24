// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/rtclock.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_rtclock_now", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_rtclock_now();
    }
}
