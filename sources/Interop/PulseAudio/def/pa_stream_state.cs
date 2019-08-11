// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    //[NativeTypeName("unsigned int")]
    public enum pa_stream_state : uint
    {
        PA_STREAM_UNCONNECTED,
        PA_STREAM_CREATING,
        PA_STREAM_READY,
        PA_STREAM_FAILED,
        PA_STREAM_TERMINATED,
    }
}
