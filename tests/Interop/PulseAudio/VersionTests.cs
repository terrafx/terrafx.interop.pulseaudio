// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides tests for libpulse's version functions.</summary>
    [TestFixture]
    [Platform("Linux")]
    public static unsafe class PulseVersionTests
    {
        /// <summary>Validates that the correct calling convention and entry point is used for <see cref="Pulse.pa_get_library_version"/>.</summary>
        [Test]
        public static void GetLibraryVersionReturnsValidString()
        {
            var str = Marshal.PtrToStringUTF8((IntPtr)Pulse.pa_get_library_version());

            Assert.False(string.IsNullOrWhiteSpace(str));

            Assert.True(Version.TryParse(str, out var version));
            Assert.GreaterOrEqual(version!.Major, 12);
        }
    }
}
