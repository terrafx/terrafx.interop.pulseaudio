// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_direction_t : uint
{
    PA_DIRECTION_OUTPUT = 0x0001U,
    PA_DIRECTION_INPUT = 0x0002U,
}
