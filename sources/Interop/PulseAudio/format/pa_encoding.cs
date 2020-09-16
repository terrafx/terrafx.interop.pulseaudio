// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/format.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public enum pa_encoding
    {
        PA_ENCODING_ANY,
        PA_ENCODING_PCM,
        PA_ENCODING_AC3_IEC61937,
        PA_ENCODING_EAC3_IEC61937,
        PA_ENCODING_MPEG_IEC61937,
        PA_ENCODING_DTS_IEC61937,
        PA_ENCODING_MPEG2_AAC_IEC61937,
        PA_ENCODING_TRUEHD_IEC61937,
        PA_ENCODING_DTSHD_IEC61937,
        PA_ENCODING_MAX,
        PA_ENCODING_INVALID = -1,
    }
}
