// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/utf8.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_valid([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_ascii_valid([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_filter([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_ascii_filter([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_utf8_to_locale([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_locale_to_utf8([NativeTypeName("const char *")] sbyte* str);
    }
}
