// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/sample.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;
using static TerraFX.Interop.pa_sample_format;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_bytes_per_second([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_frame_size([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_sample_size([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_sample_size_of_format([NativeTypeName("pa_sample_format_t")] pa_sample_format f);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern nuint pa_bytes_to_usec([NativeTypeName("uint64_t")] nuint length, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint pa_usec_to_bytes([NativeTypeName("pa_usec_t")] nuint t, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_sample_spec *")]
        public static extern pa_sample_spec* pa_sample_spec_init([NativeTypeName("pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_format_valid([NativeTypeName("unsigned int")] uint format);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_rate_valid([NativeTypeName("uint32_t")] uint rate);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_channels_valid([NativeTypeName("uint8_t")] byte channels);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_spec_valid([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_spec_equal([NativeTypeName("const pa_sample_spec *")] pa_sample_spec* a, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_sample_format_to_string([NativeTypeName("pa_sample_format_t")] pa_sample_format f);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_sample_format_t")]
        public static extern pa_sample_format pa_parse_sample_format([NativeTypeName("const char *")] sbyte* format);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_sample_spec_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* spec);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_bytes_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("unsigned int")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_format_is_le([NativeTypeName("pa_sample_format_t")] pa_sample_format f);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_sample_format_is_be([NativeTypeName("pa_sample_format_t")] pa_sample_format f);

        [NativeTypeName("#define PA_CHANNELS_MAX 32U")]
        public const uint PA_CHANNELS_MAX = 32U;

        [NativeTypeName("#define PA_RATE_MAX (48000U*8U)")]
        public const uint PA_RATE_MAX = (48000U * 8U);

        [NativeTypeName("#define PA_SAMPLE_S16NE PA_SAMPLE_S16LE")]
        public const pa_sample_format PA_SAMPLE_S16NE = PA_SAMPLE_S16LE;

        [NativeTypeName("#define PA_SAMPLE_FLOAT32NE PA_SAMPLE_FLOAT32LE")]
        public const pa_sample_format PA_SAMPLE_FLOAT32NE = PA_SAMPLE_FLOAT32LE;

        [NativeTypeName("#define PA_SAMPLE_S32NE PA_SAMPLE_S32LE")]
        public const pa_sample_format PA_SAMPLE_S32NE = PA_SAMPLE_S32LE;

        [NativeTypeName("#define PA_SAMPLE_S24NE PA_SAMPLE_S24LE")]
        public const pa_sample_format PA_SAMPLE_S24NE = PA_SAMPLE_S24LE;

        [NativeTypeName("#define PA_SAMPLE_S24_32NE PA_SAMPLE_S24_32LE")]
        public const pa_sample_format PA_SAMPLE_S24_32NE = PA_SAMPLE_S24_32LE;

        [NativeTypeName("#define PA_SAMPLE_S16RE PA_SAMPLE_S16BE")]
        public const pa_sample_format PA_SAMPLE_S16RE = PA_SAMPLE_S16BE;

        [NativeTypeName("#define PA_SAMPLE_FLOAT32RE PA_SAMPLE_FLOAT32BE")]
        public const pa_sample_format PA_SAMPLE_FLOAT32RE = PA_SAMPLE_FLOAT32BE;

        [NativeTypeName("#define PA_SAMPLE_S32RE PA_SAMPLE_S32BE")]
        public const pa_sample_format PA_SAMPLE_S32RE = PA_SAMPLE_S32BE;

        [NativeTypeName("#define PA_SAMPLE_S24RE PA_SAMPLE_S24BE")]
        public const pa_sample_format PA_SAMPLE_S24RE = PA_SAMPLE_S24BE;

        [NativeTypeName("#define PA_SAMPLE_S24_32RE PA_SAMPLE_S24_32BE")]
        public const pa_sample_format PA_SAMPLE_S24_32RE = PA_SAMPLE_S24_32BE;

        [NativeTypeName("#define PA_SAMPLE_FLOAT32 PA_SAMPLE_FLOAT32NE")]
        public const pa_sample_format PA_SAMPLE_FLOAT32 = PA_SAMPLE_FLOAT32LE;

        [NativeTypeName("#define PA_SAMPLE_SPEC_SNPRINT_MAX 32")]
        public const int PA_SAMPLE_SPEC_SNPRINT_MAX = 32;

        [NativeTypeName("#define PA_BYTES_SNPRINT_MAX 11")]
        public const int PA_BYTES_SNPRINT_MAX = 11;
    }
}
