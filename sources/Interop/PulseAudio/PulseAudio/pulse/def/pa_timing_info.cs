// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

public partial struct pa_timing_info
{
    [NativeTypeName("struct timeval")]
    public timeval timestamp;

    public int synchronized_clocks;

    [NativeTypeName("pa_usec_t")]
    public nuint sink_usec;

    [NativeTypeName("pa_usec_t")]
    public nuint source_usec;

    [NativeTypeName("pa_usec_t")]
    public nuint transport_usec;

    public int playing;

    public int write_index_corrupt;

    [NativeTypeName("int64_t")]
    public nint write_index;

    public int read_index_corrupt;

    [NativeTypeName("int64_t")]
    public nint read_index;

    [NativeTypeName("pa_usec_t")]
    public nuint configured_sink_usec;

    [NativeTypeName("pa_usec_t")]
    public nuint configured_source_usec;

    [NativeTypeName("int64_t")]
    public nint since_underrun;
}
