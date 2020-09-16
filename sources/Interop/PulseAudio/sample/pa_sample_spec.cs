// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/sample.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct pa_sample_spec
    {
        [NativeTypeName("pa_sample_format_t")]
        public pa_sample_format format;

        [NativeTypeName("uint32_t")]
        public uint rate;

        [NativeTypeName("uint8_t")]
        public byte channels;
    }
}
