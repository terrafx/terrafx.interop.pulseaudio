// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public static partial class Pulse
    {
        public static bool PA_CONTEXT_IS_GOOD([NativeTypeName("pa_context_state_t")] pa_context_state x)
        {
            return x == pa_context_state.PA_CONTEXT_CONNECTING
                || x == pa_context_state.PA_CONTEXT_AUTHORIZING
                || x == pa_context_state.PA_CONTEXT_SETTING_NAME
                || x == pa_context_state.PA_CONTEXT_READY;
        }

        public static bool PA_STREAM_IS_GOOD([NativeTypeName("pa_stream_state_t")] pa_stream_state x)
        {
            return x == pa_stream_state.PA_STREAM_CREATING
                || x == pa_stream_state.PA_STREAM_READY;
        }

        public static bool PA_SINK_IS_OPENED([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return x == pa_sink_state.PA_SINK_RUNNING
                || x == pa_sink_state.PA_SINK_IDLE;
        }

        public static bool PA_SINK_IS_RUNNING([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return x == pa_sink_state.PA_SINK_RUNNING;
        }

        public static bool PA_SOURCE_IS_OPENED([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return x == pa_source_state.PA_SOURCE_RUNNING
                || x == pa_source_state.PA_SOURCE_IDLE;
        }

        public static bool PA_SOURCE_IS_RUNNING([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return x == pa_source_state.PA_SOURCE_RUNNING;
        }
    }
}
