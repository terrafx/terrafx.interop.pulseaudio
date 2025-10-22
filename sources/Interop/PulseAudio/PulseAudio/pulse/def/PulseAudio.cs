// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using static TerraFX.Interop.PulseAudio.pa_context_state_t;
using static TerraFX.Interop.PulseAudio.pa_operation_state_t;
using static TerraFX.Interop.PulseAudio.pa_sink_state_t;
using static TerraFX.Interop.PulseAudio.pa_source_state_t;
using static TerraFX.Interop.PulseAudio.pa_stream_flags_t;
using static TerraFX.Interop.PulseAudio.pa_stream_state_t;

namespace TerraFX.Interop.PulseAudio;

public static partial class PulseAudio
{
    public static int PA_CONTEXT_IS_GOOD(pa_context_state_t x)
    {
        return (x == PA_CONTEXT_CONNECTING || x == PA_CONTEXT_AUTHORIZING || x == PA_CONTEXT_SETTING_NAME || x == PA_CONTEXT_READY) ? 1 : 0;
    }

    public static int PA_STREAM_IS_GOOD(pa_stream_state_t x)
    {
        return (x == PA_STREAM_CREATING || x == PA_STREAM_READY) ? 1 : 0;
    }

    public static int PA_SINK_IS_OPENED(pa_sink_state_t x)
    {
        return (x == PA_SINK_RUNNING || x == PA_SINK_IDLE) ? 1 : 0;
    }

    public static int PA_SINK_IS_RUNNING(pa_sink_state_t x)
    {
        return (x == PA_SINK_RUNNING) ? 1 : 0;
    }

    public static int PA_SOURCE_IS_OPENED(pa_source_state_t x)
    {
        return (x == PA_SOURCE_RUNNING || x == PA_SOURCE_IDLE) ? 1 : 0;
    }

    public static int PA_SOURCE_IS_RUNNING(pa_source_state_t x)
    {
        return (x == PA_SOURCE_RUNNING) ? 1 : 0;
    }

    [NativeTypeName("#define PA_OPERATION_CANCELED PA_OPERATION_CANCELLED")]
    public const pa_operation_state_t PA_OPERATION_CANCELED = PA_OPERATION_CANCELLED;

    [NativeTypeName("#define PA_INVALID_INDEX ((uint32_t) -1)")]
    public const uint PA_INVALID_INDEX = unchecked((uint)(-1));

    [NativeTypeName("#define PA_STREAM_NOT_MONOTONOUS PA_STREAM_NOT_MONOTONIC")]
    public const pa_stream_flags_t PA_STREAM_NOT_MONOTONOUS = PA_STREAM_NOT_MONOTONIC;

    [NativeTypeName("#define PA_STREAM_EVENT_REQUEST_CORK \"request-cork\"")]
    public static ReadOnlySpan<byte> PA_STREAM_EVENT_REQUEST_CORK => [0x72, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x2D, 0x63, 0x6F, 0x72, 0x6B, 0x00];

    [NativeTypeName("#define PA_STREAM_EVENT_REQUEST_UNCORK \"request-uncork\"")]
    public static ReadOnlySpan<byte> PA_STREAM_EVENT_REQUEST_UNCORK => [0x72, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x2D, 0x75, 0x6E, 0x63, 0x6F, 0x72, 0x6B, 0x00];

    [NativeTypeName("#define PA_STREAM_EVENT_FORMAT_LOST \"format-lost\"")]
    public static ReadOnlySpan<byte> PA_STREAM_EVENT_FORMAT_LOST => [0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x2D, 0x6C, 0x6F, 0x73, 0x74, 0x00];
}
