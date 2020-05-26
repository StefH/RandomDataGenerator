// Copied from https://raw.githubusercontent.com/SaladLab/NetLegacySupport/master/core/ConcurrentDictionary/System/Collections/Concurrent/FrameworkTraits.cs
#if NET20 || NET35
using System;
using System.Threading;

namespace RandomDataGenerator.Compatibility
{
    internal static class Volatile
    {
        public static T Read<T>(ref T location) where T : class
        {
            // 
            // The VM will replace this with a more efficient implementation.
            //
            var value = location;
            Thread.MemoryBarrier();
            return value;
        }

        public static void Write<T>(ref T location, T value) where T : class
        {
            // 
            // The VM will replace this with a more efficient implementation.
            //
            Thread.MemoryBarrier();
            location = value;
        }
    }

    internal static class PlatformHelper
    {
        public static int ProcessorCount
        {
            get { return Environment.ProcessorCount; }
        }
    }

    internal static class Monitor
    {
        public static void Enter(Object obj, ref bool lockTaken)
        {
            if (lockTaken)
                throw new ArgumentException("Argument must be initialized to false", "lockTaken");

            System.Threading.Monitor.Enter(obj);
            lockTaken = true;
        }
    }
}
#endif