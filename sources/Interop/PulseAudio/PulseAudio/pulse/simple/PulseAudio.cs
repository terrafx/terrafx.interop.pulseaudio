// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/simple.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_simple* pa_simple_new([NativeTypeName("const char *")] sbyte* server, [NativeTypeName("const char *")] sbyte* name, pa_stream_direction_t dir, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("const char *")] sbyte* stream_name, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("const pa_buffer_attr *")] pa_buffer_attr* attr, int* error);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_simple_free(pa_simple* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_simple_write(pa_simple* s, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint bytes, int* error);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_simple_drain(pa_simple* s, int* error);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_simple_read(pa_simple* s, void* data, [NativeTypeName("size_t")] nuint bytes, int* error);

    [DllImport("libpulse", ExactSpelling = true)]
    [return: NativeTypeName("pa_usec_t")]
    public static extern nuint pa_simple_get_latency(pa_simple* s, int* error);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_simple_flush(pa_simple* s, int* error);
}
