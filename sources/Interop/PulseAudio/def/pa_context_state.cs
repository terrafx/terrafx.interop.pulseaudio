// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    //[NativeTypeName("unsigned int")]
    public enum pa_context_state : uint
    {
        PA_CONTEXT_UNCONNECTED,
        PA_CONTEXT_CONNECTING,
        PA_CONTEXT_AUTHORIZING,
        PA_CONTEXT_SETTING_NAME,
        PA_CONTEXT_READY,
        PA_CONTEXT_FAILED,
        PA_CONTEXT_TERMINATED,
    }
}
