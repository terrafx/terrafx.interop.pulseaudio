// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public unsafe partial struct pa_card_profile_info2
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("const char *")]
    public sbyte* description;

    [NativeTypeName("uint32_t")]
    public uint n_sinks;

    [NativeTypeName("uint32_t")]
    public uint n_sources;

    [NativeTypeName("uint32_t")]
    public uint priority;

    public int available;
}
