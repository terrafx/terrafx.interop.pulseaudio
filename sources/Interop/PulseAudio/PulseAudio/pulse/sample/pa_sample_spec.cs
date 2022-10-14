// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/sample.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public partial struct pa_sample_spec
{
    public pa_sample_format_t format;

    [NativeTypeName("uint32_t")]
    public uint rate;

    [NativeTypeName("uint8_t")]
    public byte channels;
}
