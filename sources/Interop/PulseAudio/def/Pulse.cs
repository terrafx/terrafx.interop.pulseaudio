// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using static TerraFX.Interop.pa_context_state;
using static TerraFX.Interop.pa_sink_state;
using static TerraFX.Interop.pa_source_state;
using static TerraFX.Interop.pa_stream_state;

namespace TerraFX.Interop
{
    public static partial class Pulse
    {
        public static int PA_CONTEXT_IS_GOOD([NativeTypeName("pa_context_state_t")] pa_context_state x)
        {
            return (x == PA_CONTEXT_CONNECTING || x == PA_CONTEXT_AUTHORIZING || x == PA_CONTEXT_SETTING_NAME || x == PA_CONTEXT_READY) ? 1 : 0;
        }

        public static int PA_STREAM_IS_GOOD([NativeTypeName("pa_stream_state_t")] pa_stream_state x)
        {
            return (x == PA_STREAM_CREATING || x == PA_STREAM_READY) ? 1 : 0;
        }

        public static int PA_SINK_IS_OPENED([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return (x == PA_SINK_RUNNING || x == PA_SINK_IDLE) ? 1 : 0;
        }

        public static int PA_SINK_IS_RUNNING([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return (x == PA_SINK_RUNNING) ? 1 : 0;
        }

        public static int PA_SOURCE_IS_OPENED([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return (x == PA_SOURCE_RUNNING || x == PA_SOURCE_IDLE) ? 1 : 0;
        }

        public static int PA_SOURCE_IS_RUNNING([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return (x == PA_SOURCE_RUNNING) ? 1 : 0;
        }
    }
}
