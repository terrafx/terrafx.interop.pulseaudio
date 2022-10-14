// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/mainloop-api.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio.UnitTests;

/// <summary>Provides validation of the <see cref="pa_defer_event" /> struct.</summary>
public static unsafe partial class pa_defer_eventTests
{
    /// <summary>Validates that the <see cref="pa_defer_event" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<pa_defer_event>(), Is.EqualTo(sizeof(pa_defer_event)));
    }

    /// <summary>Validates that the <see cref="pa_defer_event" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(pa_defer_event).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="pa_defer_event" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(pa_defer_event), Is.EqualTo(1));
    }
}
