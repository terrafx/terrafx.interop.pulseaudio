// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_subscription_event_type_t : uint
{
    PA_SUBSCRIPTION_EVENT_SINK = 0x0000U,
    PA_SUBSCRIPTION_EVENT_SOURCE = 0x0001U,
    PA_SUBSCRIPTION_EVENT_SINK_INPUT = 0x0002U,
    PA_SUBSCRIPTION_EVENT_SOURCE_OUTPUT = 0x0003U,
    PA_SUBSCRIPTION_EVENT_MODULE = 0x0004U,
    PA_SUBSCRIPTION_EVENT_CLIENT = 0x0005U,
    PA_SUBSCRIPTION_EVENT_SAMPLE_CACHE = 0x0006U,
    PA_SUBSCRIPTION_EVENT_SERVER = 0x0007U,
    PA_SUBSCRIPTION_EVENT_AUTOLOAD = 0x0008U,
    PA_SUBSCRIPTION_EVENT_CARD = 0x0009U,
    PA_SUBSCRIPTION_EVENT_FACILITY_MASK = 0x000FU,
    PA_SUBSCRIPTION_EVENT_NEW = 0x0000U,
    PA_SUBSCRIPTION_EVENT_CHANGE = 0x0010U,
    PA_SUBSCRIPTION_EVENT_REMOVE = 0x0020U,
    PA_SUBSCRIPTION_EVENT_TYPE_MASK = 0x0030U,
}
