// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/util.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_user_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_host_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_fqdn([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_home_dir([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_get_binary_name([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_path_get_filename([NativeTypeName("const char *")] sbyte* p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_msleep([NativeTypeName("unsigned long")] nuint t);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_thread_make_realtime(int rtprio);
    }
}
