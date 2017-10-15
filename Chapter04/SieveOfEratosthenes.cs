using System;
using System.Collections.Generic;
using System.Numerics;

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
    public class SieveOfEratosthenes
    {
        public List<BigInteger> GeneratePrimes(BigInteger maxValue)
        {
            var primes = new List<BigInteger>();

            return primes;
        }
    }
}
