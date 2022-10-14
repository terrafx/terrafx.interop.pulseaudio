// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/direction.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", EntryPoint = "_Z18pa_direction_valid12pa_direction", ExactSpelling = true)]
    public static extern int pa_direction_valid(pa_direction_t direction);

    [DllImport("libpulse", EntryPoint = "_Z22pa_direction_to_string12pa_direction", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* pa_direction_to_string(pa_direction_t direction);
}
