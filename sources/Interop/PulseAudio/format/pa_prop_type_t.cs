// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/format.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public enum pa_prop_type_t
    {
        PA_PROP_TYPE_INT,
        PA_PROP_TYPE_INT_RANGE,
        PA_PROP_TYPE_INT_ARRAY,
        PA_PROP_TYPE_STRING,
        PA_PROP_TYPE_STRING_ARRAY,
        PA_PROP_TYPE_INVALID = -1,
    }
}
