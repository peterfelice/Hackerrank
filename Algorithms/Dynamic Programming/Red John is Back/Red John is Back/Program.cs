using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());
            for (int i = 0; i < T; i++) {
                int N = int.Parse(Console.ReadLine().Trim());
                long combinations = 0;
                int size = Math.Max(4, N);
                long[] dp = new long[size + 1];
                dp[0] = 0;
                dp[1] = 1;
                dp[2] = 1;
                dp[3] = 1;
                dp[4] = 2;

                for (int j = 5; j <= N; j++) {
                    dp[j] = dp[j - 1] + dp[j - 4];
                }
                combinations = dp[N];
                long primes = numPrimeUpTo(combinations);

                Console.WriteLine(primes);
            }



        }



        static int numPrimeUpTo(long n) {
            bool[] notPrime = new bool[n + 1];
            notPrime[0] = true;
            notPrime[1] = true;
            for (int i = 2; i <= Math.Sqrt(notPrime.Length); i++) {
                if (!notPrime[i]) {
                    for (int j = i * 2; j < notPrime.Length; j += i) {
                        notPrime[j] = true;
                    }
                }
            }
            return notPrime.Count(x => !x);
        }
    }
}
