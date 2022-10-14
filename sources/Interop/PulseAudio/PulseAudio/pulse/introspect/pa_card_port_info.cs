// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public unsafe partial struct pa_card_port_info
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("const char *")]
    public sbyte* description;

    [NativeTypeName("uint32_t")]
    public uint priority;

    public int available;

    public int direction;

    [NativeTypeName("uint32_t")]
    public uint n_profiles;

    public pa_card_profile_info** profiles;

    public pa_proplist* proplist;

    [NativeTypeName("int64_t")]
    public nint latency_offset;

    public pa_card_profile_info2** profiles2;
}
