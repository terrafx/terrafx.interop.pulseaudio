// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/direction.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_direction_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_direction_valid([NativeTypeName("pa_direction_t")] pa_direction direction);

        [DllImport(libraryPath, EntryPoint = "pa_direction_to_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_direction_to_string([NativeTypeName("pa_direction_t")] pa_direction direction);
    }
}
