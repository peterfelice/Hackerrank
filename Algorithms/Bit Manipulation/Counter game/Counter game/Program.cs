using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                UInt64 N = UInt64.Parse(Console.ReadLine().Trim());
                int counter = 0;

                while (N > 1) {
                    if ((N & (N - 1)) == 0) {
                        N >>= 1;
                    }
                    else {
                        N &= NotHighBit(N);
                    }
                    counter ^= 1;
                }
                Console.WriteLine(counter == 0 ? "Richard" : "Louise");
            }
        }

        static UInt64 NotHighBit(UInt64 n) {
            n |= (n >> 1);
            n |= (n >> 2);
            n |= (n >> 4);
            n |= (n >> 8);
            n |= (n >> 16);
            n |= (n >> 32);
            return ~(n - (n >> 1));
        }

    }
}
