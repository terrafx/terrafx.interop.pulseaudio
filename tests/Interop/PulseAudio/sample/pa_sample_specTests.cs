// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/sample.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="pa_sample_spec" /> struct.</summary>
    public static unsafe class pa_sample_specTests
    {
        /// <summary>Validates that the <see cref="pa_sample_spec" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<pa_sample_spec>(), Is.EqualTo(sizeof(pa_sample_spec)));
        }

        /// <summary>Validates that the <see cref="pa_sample_spec" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(pa_sample_spec).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="pa_sample_spec" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(pa_sample_spec), Is.EqualTo(12));
        }
    }
}
