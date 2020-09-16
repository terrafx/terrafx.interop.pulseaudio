// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_stream_flags : uint
    {
        PA_STREAM_NOFLAGS = 0x0000U,
        PA_STREAM_START_CORKED = 0x0001U,
        PA_STREAM_INTERPOLATE_TIMING = 0x0002U,
        PA_STREAM_NOT_MONOTONIC = 0x0004U,
        PA_STREAM_AUTO_TIMING_UPDATE = 0x0008U,
        PA_STREAM_NO_REMAP_CHANNELS = 0x0010U,
        PA_STREAM_NO_REMIX_CHANNELS = 0x0020U,
        PA_STREAM_FIX_FORMAT = 0x0040U,
        PA_STREAM_FIX_RATE = 0x0080U,
        PA_STREAM_FIX_CHANNELS = 0x0100,
        PA_STREAM_DONT_MOVE = 0x0200U,
        PA_STREAM_VARIABLE_RATE = 0x0400U,
        PA_STREAM_PEAK_DETECT = 0x0800U,
        PA_STREAM_START_MUTED = 0x1000U,
        PA_STREAM_ADJUST_LATENCY = 0x2000U,
        PA_STREAM_EARLY_REQUESTS = 0x4000U,
        PA_STREAM_DONT_INHIBIT_AUTO_SUSPEND = 0x8000U,
        PA_STREAM_START_UNMUTED = 0x10000U,
        PA_STREAM_FAIL_ON_SUSPEND = 0x20000U,
        PA_STREAM_RELATIVE_VOLUME = 0x40000U,
        PA_STREAM_PASSTHROUGH = 0x80000U,
    }
}
