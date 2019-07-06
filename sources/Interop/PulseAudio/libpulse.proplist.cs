using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct pa_proplist
    {
    }

    public enum pa_update_mode : uint
    {
        PA_UPDATE_SET,
        PA_UPDATE_MERGE,
        PA_UPDATE_REPLACE,
    }

    public static unsafe partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_proplist_new", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_new();

        [DllImport(DllName, EntryPoint = "pa_proplist_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_proplist_free([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_key_valid", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_key_valid([NativeTypeName("const char *")] sbyte* key);

        [DllImport(DllName, EntryPoint = "pa_proplist_sets", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_sets([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(DllName, EntryPoint = "pa_proplist_setp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_setp([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* pair);

        [DllImport(DllName, EntryPoint = "pa_proplist_setf", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_setf([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* format);

        [DllImport(DllName, EntryPoint = "pa_proplist_set", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_set([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr nbytes);

        [DllImport(DllName, EntryPoint = "pa_proplist_gets", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_gets([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(DllName, EntryPoint = "pa_proplist_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_get([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] UIntPtr* nbytes);

        [DllImport(DllName, EntryPoint = "pa_proplist_update", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_proplist_update([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("pa_update_mode_t")] pa_update_mode mode, [NativeTypeName("const pa_proplist *")] pa_proplist* other);

        [DllImport(DllName, EntryPoint = "pa_proplist_unset", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_unset([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(DllName, EntryPoint = "pa_proplist_unset_many", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_unset_many([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *const []")] sbyte* keys);

        [DllImport(DllName, EntryPoint = "pa_proplist_iterate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* pa_proplist_iterate([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("void **")] void** state);

        [DllImport(DllName, EntryPoint = "pa_proplist_to_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_to_string_sep", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_proplist_to_string_sep([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* sep);

        [DllImport(DllName, EntryPoint = "pa_proplist_from_string", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_from_string([NativeTypeName("const char *")] sbyte* str);

        [DllImport(DllName, EntryPoint = "pa_proplist_contains", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_contains([NativeTypeName("pa_proplist *")] pa_proplist* p, [NativeTypeName("const char *")] sbyte* key);

        [DllImport(DllName, EntryPoint = "pa_proplist_clear", CallingConvention = CallingConvention.Cdecl)]
        public static extern void pa_proplist_clear([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_copy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_proplist *")]
        public static extern pa_proplist* pa_proplist_copy([NativeTypeName("const pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_size", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint pa_proplist_size([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_isempty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_isempty([NativeTypeName("pa_proplist *")] pa_proplist* p);

        [DllImport(DllName, EntryPoint = "pa_proplist_equal", CallingConvention = CallingConvention.Cdecl)]
        public static extern int pa_proplist_equal([NativeTypeName("pa_proplist *")] pa_proplist* a, [NativeTypeName("pa_proplist *")] pa_proplist* b);
    }
}
