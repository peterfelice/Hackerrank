using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank {
    class Solution {
        static bool[] sieve = new bool[1000001];
        static List<int> primes;
        static Dictionary<int, int> cache = new Dictionary<int, int>();

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            int[] triangleFactors = new int[1002];
            triangleFactors[1] = 1;
            sieve[0] = true;
            sieve[1] = true;

            for (int i = 2; i < sieve.Length; i++) {
                for (int j = i + i; j < sieve.Length; j += i) {
                    sieve[j] = true;
                }
            }

            primes = Enumerable.Range(0, sieve.Length).Where(x => !sieve[x]).ToList();
            int numFactors1 = 1;

            for (int i = 2; i <= 100001; i++) {

                int numFactors2 = NumFactors((i + 1) % 2 == 0 ? (i + 1) / 2 : (i + 1));
                int numFactors = numFactors1 * numFactors2;
                numFactors1 = numFactors2;

                numFactors = Math.Min(1001, numFactors);
                if (triangleFactors[numFactors] == 0) {
                    triangleFactors[numFactors] = i;
                }

                if (numFactors >= 1000) {
                    break;
                }

            }

            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                int index = triangleFactors.Skip(N + 1).Where(x => x > 0).Min();
                Console.WriteLine((index * (index + 1)) / 2);
            }
        }


        static int NumFactors(int num) {

            int numFactors;
            bool isCached = cache.TryGetValue(num, out numFactors); ;
            if (isCached) {
                return numFactors;
            }

            Dictionary<int, int> primeFactors = new Dictionary<int, int>();

            foreach (int prime in primes) {
                if (prime > num) break;

                int count = 0;
                while (num % prime == 0) {
                    num /= prime;
                    count++;
                }

                if (count > 0) {
                    primeFactors.Add(prime, count);
                }
            }

            numFactors = 1;
            foreach (int value in primeFactors.Values) {
                numFactors *= value + 1;
            }

            return numFactors;
        }
    }
}
