using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides tests for libpulse's version functions.</summary>
    public static unsafe class PulseVersionTests
    {
        /// <summary>Validates that the correct calling convention and entry point is used for <see cref="Pulse.pa_get_library_version"/>.</summary>
        [Test]
        public static void GetLibraryVersionReturnsValidString()
        {
            var str = Marshal.PtrToStringUTF8((IntPtr)Pulse.pa_get_library_version());

            Assert.False(string.IsNullOrWhiteSpace(str));

            // Assuming the library follows semantic versioning here. Change if
            // not correct.
            StringAssert.StartsWith("12.", str);
        }
    }
}
