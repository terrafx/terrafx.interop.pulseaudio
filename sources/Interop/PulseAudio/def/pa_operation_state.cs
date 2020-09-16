// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_operation_state : uint
    {
        PA_OPERATION_RUNNING,
        PA_OPERATION_DONE,
        PA_OPERATION_CANCELLED,
    }
}
