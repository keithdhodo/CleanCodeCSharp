using System;
using System.Collections.Generic;

namespace Chapter04
{
    /// <summary>
    /// This class Generates Prime numbers up to
    /// a user specified maximum. The algorithm used
    /// is the Sieve of Eratosthenes.
    /// 
    /// Eratosthenes of Cyrene, 276 BCE, Cyrene Libya -- 194 BCE, Alexandria.
    /// The first man to calculate the circumference of the Earth. Also known
    /// for working on calendars with leap years and ran the library at Alexandria.
    /// 
    /// The algorithm is quite simple. Given an array of integers starting at 2.
    /// Cross out the multiples of 2. Find the next uncrossed integer and cross out all its
    /// multiples. Repeat until you have passed the square root of the maximum value.
    /// </summary>
    public class PrimeGenerator
    {
        public bool[] CrossedOut { get; private set; }
        public List<int> Result { get; private set; }

        private int crossedOutLength;

        public List<int> GeneratePrimes(int maxValue)
        {
            Result = new List<int>();

            if (maxValue >= 2)
            {
                UncrossIntegersUpTo(maxValue);
                CrossOutMultiples();
                PutUncrossedIntegersIntoResult();
            }

            return Result;
        }

        private void CrossOutMultiples()
        {
            int limit = DetermineIterationLimit();
            for (int i = 2; i <= limit; i++)
            {
                if (NotCrossed(i))
                {
                    CrossOutMultiplesOf(i);
                }
            }
        }

        private void CrossOutMultiplesOf(int i)
        {
            for (int multiple = 2 *i; multiple < crossedOutLength; multiple += i)
            {
                CrossedOut[multiple] = true;
            }
        }

        private bool NotCrossed(int i)
        {
            return CrossedOut[i] == false;
        }

        private int DetermineIterationLimit()
        {
            // Every multiple in the array has a prime factor that is less than or equal to the root of the array size,
            // so we don't have to cross out multiple of numbers larger than the root.
            var iterationLimit = Math.Sqrt(CrossedOut.Length);
            return (int)iterationLimit;
        }

        private void PutUncrossedIntegersIntoResult()
        {
            Result = new List<int>(NumberOfUncrossedIntegers());
            for (int j = 0, i = 2; i < crossedOutLength; i++)
            {
                if (NotCrossed(i))
                {
                    Result.Add(i);
                    j++;
                }
            }
        }

        private int NumberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i < crossedOutLength; i++)
            {
                if (NotCrossed(i))
                {
                    count++;
                }
            }

            return count;
        }

        private void UncrossIntegersUpTo(int maxValue)
        {
            CrossedOut = new bool[maxValue + 1];
            crossedOutLength = CrossedOut.Length;

            for (int i = 0; i < crossedOutLength; i++)
            {
                CrossedOut[i] = false;
            }
        }
    }
}
