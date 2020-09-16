// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct pa_source_info
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("const char *")]
        public sbyte* description;

        public pa_sample_spec sample_spec;

        public pa_channel_map channel_map;

        [NativeTypeName("uint32_t")]
        public uint owner_module;

        public pa_cvolume volume;

        public int mute;

        [NativeTypeName("uint32_t")]
        public uint monitor_of_sink;

        [NativeTypeName("const char *")]
        public sbyte* monitor_of_sink_name;

        [NativeTypeName("pa_usec_t")]
        public nuint latency;

        [NativeTypeName("const char *")]
        public sbyte* driver;

        [NativeTypeName("pa_source_flags_t")]
        public pa_source_flags flags;

        [NativeTypeName("pa_proplist *")]
        public IntPtr proplist;

        [NativeTypeName("pa_usec_t")]
        public nuint configured_latency;

        [NativeTypeName("pa_volume_t")]
        public uint base_volume;

        [NativeTypeName("pa_source_state_t")]
        public pa_source_state state;

        [NativeTypeName("uint32_t")]
        public uint n_volume_steps;

        [NativeTypeName("uint32_t")]
        public uint card;

        [NativeTypeName("uint32_t")]
        public uint n_ports;

        [NativeTypeName("pa_source_port_info **")]
        public pa_source_port_info** ports;

        [NativeTypeName("pa_source_port_info *")]
        public pa_source_port_info* active_port;

        [NativeTypeName("uint8_t")]
        public byte n_formats;

        [NativeTypeName("pa_format_info **")]
        public pa_format_info** formats;
    }
}
