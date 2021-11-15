// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio
{
    [NativeTypeName("unsigned int")]
    public enum pa_context_flags_t : uint
    {
        PA_CONTEXT_NOFLAGS = 0x0000U,
        PA_CONTEXT_NOAUTOSPAWN = 0x0001U,
        PA_CONTEXT_NOFAIL = 0x0002U,
    }
}
