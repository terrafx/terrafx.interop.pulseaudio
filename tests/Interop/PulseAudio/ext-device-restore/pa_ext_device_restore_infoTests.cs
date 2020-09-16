// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/ext-device-restore.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="pa_ext_device_restore_info" /> struct.</summary>
    public static unsafe class pa_ext_device_restore_infoTests
    {
        /// <summary>Validates that the <see cref="pa_ext_device_restore_info" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<pa_ext_device_restore_info>(), Is.EqualTo(sizeof(pa_ext_device_restore_info)));
        }

        /// <summary>Validates that the <see cref="pa_ext_device_restore_info" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(pa_ext_device_restore_info).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="pa_ext_device_restore_info" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(pa_ext_device_restore_info), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(pa_ext_device_restore_info), Is.EqualTo(16));
            }
        }
    }
}
