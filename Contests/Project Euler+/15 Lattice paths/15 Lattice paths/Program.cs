using System;
using System.Numerics;

namespace HackerRank {
    class Solution {
        private static void Main(string[] args) {
            int modulus = 1000000007;
            int T = int.Parse(Console.ReadLine().Trim());
            for (int testCase = 0; testCase < T; testCase++) {
                int[] NM = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int N = NM[0];
                int M = NM[1];
                long[] values = new long[M];
                for (int n = 0; n < N; n++) {
                    for (int m = 0; m < M; m++) {
                        values[m] = ((n == 0 ? 1 : values[m]) + (m == 0 ? 1 : values[m - 1])) % modulus;
                    }
                }
                Console.WriteLine(values[M - 1]);
            }
        }
    }
}
