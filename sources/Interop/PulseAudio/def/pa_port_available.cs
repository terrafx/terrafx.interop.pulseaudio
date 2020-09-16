// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_port_available : uint
    {
        PA_PORT_AVAILABLE_UNKNOWN = 0,
        PA_PORT_AVAILABLE_NO = 1,
        PA_PORT_AVAILABLE_YES = 2,
    }
}
