// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/timeval.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_gettimeofday([NativeTypeName("struct timeval *")] timeval* tv);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern nuint pa_timeval_diff([NativeTypeName("const struct timeval *")] timeval* a, [NativeTypeName("const struct timeval *")] timeval* b);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_timeval_cmp([NativeTypeName("const struct timeval *")] timeval* a, [NativeTypeName("const struct timeval *")] timeval* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern nuint pa_timeval_age([NativeTypeName("const struct timeval *")] timeval* tv);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_add([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] nuint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_sub([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] nuint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("struct timeval *")]
        public static extern timeval* pa_timeval_store([NativeTypeName("struct timeval *")] timeval* tv, [NativeTypeName("pa_usec_t")] nuint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern nuint pa_timeval_load([NativeTypeName("const struct timeval *")] timeval* tv);
    }
}
