using System;
using System.Numerics;

namespace HackerRank {
    class Solution {
        private static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine().Trim());
            BigInteger sum = 0;

            for (int testCase = 0; testCase < N; testCase++) {
                BigInteger num = BigInteger.Parse(Console.ReadLine().Trim());
                sum += num;
            }

            Console.WriteLine(sum.ToString().Substring(0, 10));
        }
    }
}
