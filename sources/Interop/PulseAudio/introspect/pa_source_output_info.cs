// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/introspect.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_source_output_info
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        [NativeTypeName("uint32_t")]
        public uint client;

        [NativeTypeName("uint32_t")]
        public uint source;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr buffer_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr source_usec;

        [NativeTypeName("const char *")]
        public sbyte* resample_method;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_proplist *")]
        public pa_proplist* proplist;

        public int corked;

        public pa_cvolume volume;

        public int mute;

        public int has_volume;

        public int volume_writable;

        [NativeTypeName("pa_format_info *")]
        public pa_format_info* format;
    }
}
