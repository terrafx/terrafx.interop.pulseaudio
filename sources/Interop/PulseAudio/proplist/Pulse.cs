// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/proplist.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_new();

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_proplist_free([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_key_valid([NativeTypeName("const char *")] sbyte* key);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_sets([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_setp([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* pair);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_setf([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* format);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_set([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint nbytes);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_gets([NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_get([NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] nuint* nbytes);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_proplist_update([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("const pa_proplist *")] pa_proplist* other);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_unset([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_unset_many([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *const []")] sbyte** keys);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_iterate([NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("void **")] void** state);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string_sep([NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* sep);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_from_string([NativeTypeName("const char *")] sbyte* str);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_contains([NativeTypeName("const pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_proplist_clear([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_copy([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint pa_proplist_size([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_isempty([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_proplist_equal([NativeTypeName("const pa_proplist *")] pa_proplist* a, [NativeTypeName("const pa_proplist *")] pa_proplist* b);
    }
}
