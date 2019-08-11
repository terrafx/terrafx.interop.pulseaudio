// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/def.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct pa_timing_info
    {
        [NativeTypeName("struct timeval")]
        public timeval timestamp;

        public int synchronized_clocks;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr sink_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr source_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr transport_usec;

        public int playing;

        public int write_index_corrupt;

        [NativeTypeName("int64_t")]
        public IntPtr write_index;

        public int read_index_corrupt;

        [NativeTypeName("int64_t")]
        public IntPtr read_index;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_sink_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_source_usec;

        [NativeTypeName("int64_t")]
        public IntPtr since_underrun;
    }
}
