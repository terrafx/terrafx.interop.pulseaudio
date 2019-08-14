// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct pa_spawn_api
    {
        [NativeTypeName("void (*)()")]
        public IntPtr prefork;

        [NativeTypeName("void (*)()")]
        public IntPtr postfork;

        [NativeTypeName("void (*)()")]
        public IntPtr atfork;
    }
}
