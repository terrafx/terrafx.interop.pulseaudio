// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.PulseAudio
{
    public static unsafe partial class PulseAudio
    {
        public static event DllImportResolver? ResolveLibrary;

        static PulseAudio()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }

        private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (TryResolveLibrary(libraryName, assembly, searchPath, out var nativeLibrary))
            {
                return nativeLibrary;
            }

            if (libraryName.Equals("libpulse") && TryResolveLibPulse(assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            return IntPtr.Zero;
        }

        private static bool TryResolveLibPulse(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (NativeLibrary.TryLoad("libpulse.so.0", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }

            return NativeLibrary.TryLoad("libpulse", assembly, searchPath, out nativeLibrary);
        }

        private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            var resolveLibrary = ResolveLibrary;

            if (resolveLibrary != null)
            {
                var resolvers = resolveLibrary.GetInvocationList();

                foreach (DllImportResolver resolver in resolvers)
                {
                    nativeLibrary = resolver(libraryName, assembly, searchPath);

                    if (nativeLibrary != IntPtr.Zero)
                    {
                        return true;
                    }
                }
            }

            nativeLibrary = IntPtr.Zero;
            return false;
        }
    }
}
