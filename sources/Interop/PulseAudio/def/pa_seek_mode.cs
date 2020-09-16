// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_seek_mode : uint
    {
        PA_SEEK_RELATIVE = 0,
        PA_SEEK_ABSOLUTE = 1,
        PA_SEEK_RELATIVE_ON_READ = 2,
        PA_SEEK_RELATIVE_END = 3,
    }
}
