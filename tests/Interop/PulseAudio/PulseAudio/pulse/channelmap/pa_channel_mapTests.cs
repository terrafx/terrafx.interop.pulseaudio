// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/channelmap.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio.UnitTests
{
    /// <summary>Provides validation of the <see cref="pa_channel_map" /> struct.</summary>
    public static unsafe partial class pa_channel_mapTests
    {
        /// <summary>Validates that the <see cref="pa_channel_map" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<pa_channel_map>(), Is.EqualTo(sizeof(pa_channel_map)));
        }

        /// <summary>Validates that the <see cref="pa_channel_map" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(pa_channel_map).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="pa_channel_map" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(pa_channel_map), Is.EqualTo(132));
        }
    }
}
