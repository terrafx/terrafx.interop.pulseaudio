// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/format.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct pa_format_info
    {
        [NativeTypeName("pa_encoding_t")]
        public pa_encoding encoding;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* plist;
    }
}
