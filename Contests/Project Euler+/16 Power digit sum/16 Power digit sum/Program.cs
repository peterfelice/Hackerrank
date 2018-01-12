using System;
using System.Numerics;

namespace HackerRank {
    class Solution {
        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());
            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());

                BigInteger num = 1;
                for (int i = 0; i < N; i++) {
                    num *= 2;
                }

                string stringNum = num.ToString();
                int sum = 0;
                foreach (char c in stringNum) {
                    sum += int.Parse("" + c);
                }

                Console.WriteLine(sum);
            }


        }
    }
}
