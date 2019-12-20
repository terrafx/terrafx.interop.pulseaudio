// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/proplist.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(LibraryPath, EntryPoint = "pa_proplist_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_new();

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_proplist_free([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_key_valid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_key_valid([NativeTypeName("const char *")] sbyte* key);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_sets", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_sets([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_setp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_setp([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* pair);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_setf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_setf([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* format);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_set", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_set([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr nbytes);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_gets", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_gets([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_get([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] UIntPtr* nbytes);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_update", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_proplist_update([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("const pa_proplist *")] pa_proplist* other);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_unset", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_unset([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_unset_many", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_unset_many([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *const []")] sbyte* keys);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_iterate", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_iterate([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("void **")] void** state);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_to_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_to_string_sep", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string_sep([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* sep);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_from_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_from_string([NativeTypeName("const char *")] sbyte* str);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_contains", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_contains([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_clear", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pa_proplist_clear([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_copy", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_copy([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint pa_proplist_size([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_isempty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_isempty([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(LibraryPath, EntryPoint = "pa_proplist_equal", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int pa_proplist_equal([NativeTypeName("pa_proplist *")] pa_proplist* a, [NativeTypeName("pa_proplist *")] pa_proplist* b);
    }
}
