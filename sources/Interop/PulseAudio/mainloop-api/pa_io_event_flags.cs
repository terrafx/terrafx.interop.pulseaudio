// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum pa_io_event_flags : uint
    {
        PA_IO_EVENT_NULL = 0,
        PA_IO_EVENT_INPUT = 1,
        PA_IO_EVENT_OUTPUT = 2,
        PA_IO_EVENT_HANGUP = 4,
        PA_IO_EVENT_ERROR = 8,
    }
}
