// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/def.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop.PulseAudio;

[NativeTypeName("unsigned int")]
public enum pa_error_code_t : uint
{
    PA_OK = 0,
    PA_ERR_ACCESS,
    PA_ERR_COMMAND,
    PA_ERR_INVALID,
    PA_ERR_EXIST,
    PA_ERR_NOENTITY,
    PA_ERR_CONNECTIONREFUSED,
    PA_ERR_PROTOCOL,
    PA_ERR_TIMEOUT,
    PA_ERR_AUTHKEY,
    PA_ERR_INTERNAL,
    PA_ERR_CONNECTIONTERMINATED,
    PA_ERR_KILLED,
    PA_ERR_INVALIDSERVER,
    PA_ERR_MODINITFAILED,
    PA_ERR_BADSTATE,
    PA_ERR_NODATA,
    PA_ERR_VERSION,
    PA_ERR_TOOLARGE,
    PA_ERR_NOTSUPPORTED,
    PA_ERR_UNKNOWN,
    PA_ERR_NOEXTENSION,
    PA_ERR_OBSOLETE,
    PA_ERR_NOTIMPLEMENTED,
    PA_ERR_FORKED,
    PA_ERR_IO,
    PA_ERR_BUSY,
    PA_ERR_MAX,
}
