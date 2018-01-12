using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());
            double epsilon = 0.0000000001;
            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                long max = -1;
                for (int i = 1; i <= N; i++) {
                    double y = 1.0 * (N * N - 2 * N * i) / (2 * (N - i));
                    if (Math.Abs(y - (int)y) < epsilon) {
                        long product = (long)(i * y * (N - i - y));
                        max = product > max ? product : max;
                    }
                }
                Console.WriteLine(max == 0 ? -1 : max);
            }
        }
    }
}
