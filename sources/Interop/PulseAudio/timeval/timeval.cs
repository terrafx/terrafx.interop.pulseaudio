// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from sys/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

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
