using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank {
    class Solution {
        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            List<KeyValuePair<int, long>> primeSum = new List<KeyValuePair<int, long>>();
            long currentSum = 0;
            bool[] sieve = new bool[1000001];
            long[] sums = new long[1000001];
            sieve[0] = true;
            sieve[1] = true;

            for (int i = 2; i < sieve.Length; i++) {
                if (sieve[i]) {
                    sums[i] = currentSum;
                    continue;
                }
                currentSum += i;
                sums[i] = currentSum;

                for (int j = i + i; j < sieve.Length; j += i) {
                    sieve[j] = true;
                }
            }

            for (int testCase = 0; testCase < T; testCase++) {

                int N = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine(sums[N]);
            }
        }
    }
}
