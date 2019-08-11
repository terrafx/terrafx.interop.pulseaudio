// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public enum pa_sink_state
    {
        PA_SINK_INVALID_STATE = -1,
        PA_SINK_RUNNING = 0,
        PA_SINK_IDLE = 1,
        PA_SINK_SUSPENDED = 2,
        PA_SINK_INIT = -2,
        PA_SINK_UNLINKED = -3,
    }
}
