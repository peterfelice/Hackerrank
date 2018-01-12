using System;
using System.Collections.Generic;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testcase = 0; testcase < T; testcase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                if (N == 1) {
                    Console.WriteLine(1);
                    continue;
                }

                int ans = 1;
                Dictionary<int, int> primeFactors = new Dictionary<int, int>();

                for (int i = 2; i <= N; i++) {
                    Dictionary<int, int> currentPrimeFactors = PrimeFactors(i);
                    foreach (int key in currentPrimeFactors.Keys) {
                        if (!primeFactors.ContainsKey(key)) {
                            primeFactors.Add(key, 0);
                        }

                        if (currentPrimeFactors[key] > primeFactors[key]) {
                            ans = ans * key * (currentPrimeFactors[key] - primeFactors[key]);
                            primeFactors[key] = currentPrimeFactors[key];
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }


        static Dictionary<int, int> PrimeFactors(int num) {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            Dictionary<int, int> primeFactors = new Dictionary<int, int>();
            while (num > 1) {
                for (int i = 0; i < primes.Length; i++) {
                    if (num % primes[i] == 0) {
                        if (!primeFactors.ContainsKey(primes[i])) {
                            primeFactors.Add(primes[i], 0);
                        }
                        primeFactors[primes[i]]++;
                        num /= primes[i];
                        break;
                    }
                }
            }

            return primeFactors;
        }

    }
}
