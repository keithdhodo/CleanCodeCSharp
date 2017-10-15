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
        public List<int> GeneratePrimes(int maxValue)
        {
            var primes = new List<int>();

            if (maxValue >= 2) // the only valid case
            {
                // declarations
                int s = maxValue + 1; // size of the List
                bool[] f = new bool[s];

                // initialize the array to true
                for(int i = 0; i < s; i++)
                {
                    f[i] = true;
                }

                // get rid of the non-primes
                f[0] = f[1] = false;

                // sieve
                for (int i = 2; i < Math.Sqrt(s) + 1; i++)
                {
                    if (f[i]) // i is uncrossed. Cross its multiples
                    {
                        for (int j = 2 * i; j < s; j += i)
                        {
                            f[j] = false; // multiple is not prime
                        }
                    }
                }

                // how many primes are there
                int count = 0;
                for (int i = 0; i < s; i++)
                {
                    if (f[i])
                    {
                        count++; // bump count
                    }
                }

                // re-initialize the List to proper count
                primes = new List<int>(count);

                // move the primes into the list
                for (int i = 0; i < s; i++)
                {
                    if (f[i]) // if prime
                    {
                        primes.Add(i);
                    }
                }
            }

            return primes;
        }
    }
}
