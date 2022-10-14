// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/channelmap.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_channel_map_def_t : uint
{
    PA_CHANNEL_MAP_AIFF,
    PA_CHANNEL_MAP_ALSA,
    PA_CHANNEL_MAP_AUX,
    PA_CHANNEL_MAP_WAVEEX,
    PA_CHANNEL_MAP_OSS,
    PA_CHANNEL_MAP_DEF_MAX,
    PA_CHANNEL_MAP_DEFAULT = PA_CHANNEL_MAP_AIFF,
}
