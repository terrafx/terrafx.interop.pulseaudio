// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_autoload_type_t : uint
{
    PA_AUTOLOAD_SINK = 0,
    PA_AUTOLOAD_SOURCE = 1,
}
