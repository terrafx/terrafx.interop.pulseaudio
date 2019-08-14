// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    //[NativeTypeName("unsigned int")]
    public enum pa_source_flags : uint
    {
        PA_SOURCE_NOFLAGS = 0x0000U,
        PA_SOURCE_HW_VOLUME_CTRL = 0x0001U,
        PA_SOURCE_LATENCY = 0x0002U,
        PA_SOURCE_HARDWARE = 0x0004U,
        PA_SOURCE_NETWORK = 0x0008U,
        PA_SOURCE_HW_MUTE_CTRL = 0x0010U,
        PA_SOURCE_DECIBEL_VOLUME = 0x0020U,
        PA_SOURCE_DYNAMIC_LATENCY = 0x0040U,
        PA_SOURCE_FLAT_VOLUME = 0x0080U,
    }
}
