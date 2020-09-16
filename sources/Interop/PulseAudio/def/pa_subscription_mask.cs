// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_subscription_mask : uint
    {
        PA_SUBSCRIPTION_MASK_NULL = 0x0000U,
        PA_SUBSCRIPTION_MASK_SINK = 0x0001U,
        PA_SUBSCRIPTION_MASK_SOURCE = 0x0002U,
        PA_SUBSCRIPTION_MASK_SINK_INPUT = 0x0004U,
        PA_SUBSCRIPTION_MASK_SOURCE_OUTPUT = 0x0008U,
        PA_SUBSCRIPTION_MASK_MODULE = 0x0010U,
        PA_SUBSCRIPTION_MASK_CLIENT = 0x0020U,
        PA_SUBSCRIPTION_MASK_SAMPLE_CACHE = 0x0040U,
        PA_SUBSCRIPTION_MASK_SERVER = 0x0080U,
        PA_SUBSCRIPTION_MASK_AUTOLOAD = 0x0100U,
        PA_SUBSCRIPTION_MASK_CARD = 0x0200U,
        PA_SUBSCRIPTION_MASK_ALL = 0x02ffU,
    }
}
