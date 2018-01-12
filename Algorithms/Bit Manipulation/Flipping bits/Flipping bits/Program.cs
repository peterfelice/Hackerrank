using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                UInt32 N = UInt32.Parse(Console.ReadLine().Trim());
                Console.WriteLine(~N);
            }
        }
    }
}
