// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_spawn_api
    {
        [NativeTypeName("void (*)()")]
        public delegate* unmanaged<void> prefork;

        [NativeTypeName("void (*)()")]
        public delegate* unmanaged<void> postfork;

        [NativeTypeName("void (*)()")]
        public delegate* unmanaged<void> atfork;
    }
}
