// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from sys/_timeval.h in FreeBSD.
// Original source is Copyright © Holders. Licensed under the BSD 2-Clause FreeBSD License. See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct timeval
    {
        [NativeTypeName("time_t")]
        public IntPtr tv_sec;

        [NativeTypeName("suseconds_t")]
        public IntPtr tv_usec;
    }
}
