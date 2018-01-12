using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static List<int> primes = new List<int>();
    static void Main(string[] args) {
        primes.Add(2);

        int T = int.Parse(Console.ReadLine().Trim());

        for (int testcase = 0; testcase < T; testcase++) {
            int N = int.Parse(Console.ReadLine().Trim());

            if (N <= primes.Count) {
                Console.WriteLine(primes[N - 1]);
                continue;
            }

            int currentNum = primes[primes.Count - 1] + 1;
            while (primes.Count < N) {
                bool isPrime = true;
                foreach (int prime in primes) {
                    if (currentNum % prime == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    primes.Add(currentNum);
                }

                currentNum++;
            }

            Console.WriteLine(primes[N - 1]);

        }
    }
}