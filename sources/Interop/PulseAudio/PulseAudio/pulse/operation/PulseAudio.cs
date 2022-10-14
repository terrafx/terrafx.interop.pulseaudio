// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/operation.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_operation_ref(pa_operation* o);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_operation_unref(pa_operation* o);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_operation_cancel(pa_operation* o);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation_state_t pa_operation_get_state([NativeTypeName("const pa_operation *")] pa_operation* o);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_operation_set_state_callback(pa_operation* o, [NativeTypeName("pa_operation_notify_cb_t")] delegate* unmanaged<pa_operation*, void*, void> cb, void* userdata);
}
