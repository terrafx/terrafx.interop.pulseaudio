// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/operation.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern IntPtr pa_operation_ref([NativeTypeName("pa_operation *")] IntPtr o);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_operation_unref([NativeTypeName("pa_operation *")] IntPtr o);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_operation_cancel([NativeTypeName("pa_operation *")] IntPtr o);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation_state_t")]
        public static extern pa_operation_state pa_operation_get_state([NativeTypeName("const pa_operation *")] IntPtr o);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_operation_set_state_callback([NativeTypeName("pa_operation *")] IntPtr o, [NativeTypeName("pa_operation_notify_cb_t")] delegate* unmanaged<IntPtr, void*, void> cb, [NativeTypeName("void *")] void* userdata);
    }
}
