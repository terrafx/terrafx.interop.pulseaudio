// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/version.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_get_library_version();

        [NativeTypeName("#define PA_API_VERSION 12")]
        public const int PA_API_VERSION = 12;

        [NativeTypeName("#define PA_PROTOCOL_VERSION 33")]
        public const int PA_PROTOCOL_VERSION = 33;

        [NativeTypeName("#define PA_MAJOR 13")]
        public const int PA_MAJOR = 13;

        [NativeTypeName("#define PA_MINOR 99")]
        public const int PA_MINOR = 99;

        [NativeTypeName("#define PA_MICRO 0")]
        public const int PA_MICRO = 0;
    }
}
