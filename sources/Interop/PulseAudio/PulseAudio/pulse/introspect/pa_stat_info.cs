// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public partial struct pa_stat_info
{
    [NativeTypeName("uint32_t")]
    public uint memblock_total;

    [NativeTypeName("uint32_t")]
    public uint memblock_total_size;

    [NativeTypeName("uint32_t")]
    public uint memblock_allocated;

    [NativeTypeName("uint32_t")]
    public uint memblock_allocated_size;

    [NativeTypeName("uint32_t")]
    public uint scache_size;
}
