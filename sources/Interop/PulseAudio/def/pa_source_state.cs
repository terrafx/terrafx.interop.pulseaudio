// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public enum pa_source_state
    {
        PA_SOURCE_INVALID_STATE = -1,
        PA_SOURCE_RUNNING = 0,
        PA_SOURCE_IDLE = 1,
        PA_SOURCE_SUSPENDED = 2,
        PA_SOURCE_INIT = -2,
        PA_SOURCE_UNLINKED = -3,
    }
}
