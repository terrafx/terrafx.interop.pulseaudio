// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_sink_flags_t : uint
{
    PA_SINK_NOFLAGS = 0x0000U,
    PA_SINK_HW_VOLUME_CTRL = 0x0001U,
    PA_SINK_LATENCY = 0x0002U,
    PA_SINK_HARDWARE = 0x0004U,
    PA_SINK_NETWORK = 0x0008U,
    PA_SINK_HW_MUTE_CTRL = 0x0010U,
    PA_SINK_DECIBEL_VOLUME = 0x0020U,
    PA_SINK_FLAT_VOLUME = 0x0040U,
    PA_SINK_DYNAMIC_LATENCY = 0x0080U,
    PA_SINK_SET_FORMATS = 0x0100U,
}
