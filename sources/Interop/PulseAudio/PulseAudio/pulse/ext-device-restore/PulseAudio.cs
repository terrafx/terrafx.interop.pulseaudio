// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-restore.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio;

public static unsafe partial class PulseAudio
{
    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_ext_device_restore_test(pa_context* c, [NativeTypeName("pa_ext_device_restore_test_cb_t")] delegate* unmanaged<pa_context*, uint, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_ext_device_restore_subscribe(pa_context* c, int enable, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern void pa_ext_device_restore_set_subscribe_cb(pa_context* c, [NativeTypeName("pa_ext_device_restore_subscribe_cb_t")] delegate* unmanaged<pa_context*, pa_device_type_t, uint, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_ext_device_restore_read_formats_all(pa_context* c, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] delegate* unmanaged<pa_context*, pa_ext_device_restore_info*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_ext_device_restore_read_formats(pa_context* c, pa_device_type_t type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_ext_device_restore_read_device_formats_cb_t")] delegate* unmanaged<pa_context*, pa_ext_device_restore_info*, int, void*, void> cb, void* userdata);

    [DllImport("libpulse", ExactSpelling = true)]
    public static extern pa_operation* pa_ext_device_restore_save_formats(pa_context* c, pa_device_type_t type, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint8_t")] byte n_formats, pa_format_info** formats, [NativeTypeName("pa_context_success_cb_t")] delegate* unmanaged<pa_context*, int, void*, void> cb, void* userdata);
}
