// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public unsafe partial struct pa_client_info
{
    [NativeTypeName("uint32_t")]
    public uint index;

    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("uint32_t")]
    public uint owner_module;

    [NativeTypeName("const char *")]
    public sbyte* driver;

    public pa_proplist* proplist;
}
