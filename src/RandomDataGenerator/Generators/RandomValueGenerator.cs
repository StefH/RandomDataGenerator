﻿using System;

namespace RandomDataGenerator.Generators
{
    /// <summary>
    /// Copyright : http://www.cambiaresearch.com/articles/13/csharp-randomprovider-class
    /// 
    /// RandomProvider.  Provides random numbers of all data types
    /// in specified ranges. It also contains a couple of methods
    /// from Normally (Gaussian) distributed random numbers and 
    /// Exponentially distributed random numbers.
    /// </summary>
    internal static class RandomValueGenerator
    {
        private const double Tolerance = double.Epsilon;
        private static Random _rnf;
        private static double _storedUniformDeviate;
        private static bool _storedUniformDeviateIsGood;

        public static Type[] SupportedTypes { get; } = { typeof(bool), typeof(byte), typeof(short), typeof(int), typeof(long), typeof(float), typeof(double), typeof(long), typeof(DateTime), typeof(TimeSpan) };

        #region -- Construction/Initialization --

        static RandomValueGenerator()
        {
            Reset();
        }

        public static void Reset()
        {
            _rnf = new Random(Environment.TickCount);
        }

        #endregion

        #region -- Uniform Deviates --

        /// <summary>
        /// Returns double in the range [0, 1)
        /// </summary>
        public static double Next()
        {
            return _rnf.NextDouble();
        }

        /// <summary>
        /// Returns true or false randomly.
        /// </summary>
        public static bool NextBoolean()
        {
            return _rnf.Next(0, 2) != 0;
        }

        /// <summary>
        /// Returns double in the range [0, 1)
        /// </summary>
        public static double NextDouble()
        {
            return _rnf.NextDouble();
        }

        /// <summary>
        /// Return a random T in the range [min, max]
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <returns>Random T</returns>
        public static T Next<T>(T min, T max)
        {
            if (typeof(T) == typeof(bool))
            {
                return (T)(object)NextBoolean();
            }

            if (typeof(T) == typeof(byte))
            {
                return (T)(object)Next((byte)(object)min, (byte)(object)max);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)Next((short)(object)min, (short)(object)max);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)Next((int)(object)min, (int)(object)max);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)Next((long)(object)min, (long)(object)max);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)Next((float)(object)min, (float)(object)max);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Next((double)(object)min, (double)(object)max);
            }

            if (typeof(T) == typeof(DateTime))
            {
                return (T)(object)Next((DateTime)(object)min, (DateTime)(object)max);
            }

            if (typeof(T) == typeof(TimeSpan))
            {
                return (T)(object)Next((TimeSpan)(object)min, (TimeSpan)(object)max);
            }

            throw new NotSupportedException($"The type '{typeof(T)}' cannot be used.");
        }

        /// <summary>
        /// Returns byte in the range [min, max)
        /// </summary>
        public static byte Next(byte min, byte max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            double rn = (max * 1.0 - min * 1.0) * _rnf.NextDouble() + min * 1.0;
            return Convert.ToByte(rn);
        }

        /// <summary>
        /// Returns Int16 in the range [min, max)
        /// </summary>
        public static short Next(short min, short max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            double rn = (max * 1.0 - min * 1.0) * _rnf.NextDouble() + min * 1.0;
            return Convert.ToInt16(rn);
        }

        /// <summary>
        /// Returns Int32 in the range [min, max)
        /// </summary>
        public static int Next(int min, int max)
        {
            return _rnf.Next(min, max);
        }

        /// <summary>
        /// Returns Int64 in the range [min, max)
        /// </summary>
        public static long Next(long min, long max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            double rn = (max * 1.0 - min * 1.0) * _rnf.NextDouble() + min * 1.0;
            return Convert.ToInt64(rn);
        }

        /// <summary>
        /// Returns float (Single) in the range [min, max)
        /// </summary>
        public static float Next(float min, float max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            double rn = (max * 1.0 - min * 1.0) * _rnf.NextDouble() + min * 1.0;
            return Convert.ToSingle(rn);
        }

        /// <summary>
        /// Returns double in the range [min, max)
        /// </summary>
        public static double Next(double min, double max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            double rn = (max - min) * _rnf.NextDouble() + min;
            return rn;
        }

        /// <summary>
        /// Returns DateTime in the range [min, max)
        /// </summary>
        public static DateTime Next(DateTime min, DateTime max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            long minTicks = min.Ticks;
            long maxTicks = max.Ticks;
            double rn = (Convert.ToDouble(maxTicks)
                - Convert.ToDouble(minTicks)) * _rnf.NextDouble()
                + Convert.ToDouble(minTicks);
            return new DateTime(Convert.ToInt64(rn));
        }

        /// <summary>
        /// Returns TimeSpan in the range [min, max)
        /// </summary>
        public static TimeSpan Next(TimeSpan min, TimeSpan max)
        {
            if (max <= min)
            {
                throw new ArgumentException("Max must be greater than min.");
            }

            long minTicks = min.Ticks;
            long maxTicks = max.Ticks;
            double rn = (Convert.ToDouble(maxTicks)
                - Convert.ToDouble(minTicks)) * _rnf.NextDouble()
                + Convert.ToDouble(minTicks);
            return new TimeSpan(Convert.ToInt64(rn));
        }

        /// <summary>
        /// Returns double in the range [min, max)
        /// </summary>
        public static double NextUniform()
        {
            return Next();
        }

        /// <summary>
        /// Returns a uniformly random integer representing one of the values 
        /// in the enum.
        /// </summary>
        public static int NextEnum(Type enumType)
        {
            var values = (int[])Enum.GetValues(enumType);
            int randomIndex = Next(0, values.Length);
            return values[randomIndex];
        }
        #endregion

        #region -- Exponential Deviates --
        /// <summary>
        /// Returns an exponentially distributed, positive, random deviate of unit mean.
        /// </summary>
        public static double NextExponential()
        {
            double dum = 0.0;

            while (Math.Abs(dum) < Tolerance)
            {
                dum = NextUniform();
            }

            return -1.0 * Math.Log(dum, Math.E);
        }
        #endregion

        #region -- Normal Deviates --

        /// <summary>
        /// Returns a normally distributed deviate with zero mean and unit 
        /// variance.
        /// </summary>
        public static double NextNormal()
        {
            // based on algorithm from Numerical Recipes
            if (_storedUniformDeviateIsGood)
            {
                _storedUniformDeviateIsGood = false;
                return _storedUniformDeviate;
            }

            double rsq = 0.0;
            double v1 = 0.0, v2 = 0.0;
            while (rsq >= 1.0 || Math.Abs(rsq) < Tolerance)
            {
                v1 = 2.0 * Next() - 1.0;
                v2 = 2.0 * Next() - 1.0;
                rsq = v1 * v1 + v2 * v2;
            }

            double fac = Math.Sqrt(-2.0 * Math.Log(rsq, Math.E) / rsq);
            _storedUniformDeviate = v1 * fac;
            _storedUniformDeviateIsGood = true;
            return v2 * fac;
        }
        #endregion
    }
}