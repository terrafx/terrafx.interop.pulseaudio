using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class pulse
    {
        [DllImport(DllName, EntryPoint = "pa_rtclock_now", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("pa_usec_t")]
        public static extern UIntPtr pa_rtclock_now();
    }
}
