// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct pa_buffer_attr
    {
        [NativeTypeName("uint32_t")]
        public uint maxlength;

        [NativeTypeName("uint32_t")]
        public uint tlength;

        [NativeTypeName("uint32_t")]
        public uint prebuf;

        [NativeTypeName("uint32_t")]
        public uint minreq;

        [NativeTypeName("uint32_t")]
        public uint fragsize;
    }
}
