// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/scache.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_connect_upload(pa_stream* s, [NativeTypeName("size_t")] nuint length);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern int pa_stream_finish_upload(pa_stream* s);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_context_remove_sample(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_context_play_sample(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_context_play_sample_with_proplist(pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("const pa_proplist *")] pa_proplist* proplist, [NativeTypeName("pa_context_play_sample_cb_t")] delegate* unmanaged<pa_context*, uint, void*, void> cb, void* userdata);
}
