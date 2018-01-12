using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {
        static Dictionary<int, int> cache;

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                int[] nk = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int N = nk[0];
                int K = nk[1];
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse).Distinct().ToArray();
                cache = new Dictionary<int, int>();
                int closest = Closest(array, 0, K);

                Console.WriteLine(closest);
            }
        }

        static int Closest(int[] array, int currentSum, int k) {
            if (cache.ContainsKey(currentSum)) {
                return cache[currentSum];
            }
            int newSum = currentSum;
            int closestSum = currentSum;
            foreach (int i in array) {
                if (currentSum + i <= k) {
                    newSum = Closest(array, currentSum + i, k);
                }
                if (k - newSum < k - closestSum) {
                    closestSum = newSum;
                }
            }
            cache.Add(currentSum, closestSum);

            return closestSum;
        }
    }
}
