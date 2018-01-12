using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int ans = 0;
                if (N % 2 == 0) {
                    ans = 0;
                }
                else {
                    for (int i = 0; i < N; i += 2) {
                        ans ^= array[i];
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
