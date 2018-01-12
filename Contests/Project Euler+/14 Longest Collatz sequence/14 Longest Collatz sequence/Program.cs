using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {
        static int[] cache = new int[5000001];
        static int[] max = new int[5000001];

        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            int currentMaxLength = 0;
            for (int i = 1; i <= 5000000; i++) {
                int legnth = CollatzLength(i);
                max[i] = legnth >= currentMaxLength ? i : max[i - 1];
                currentMaxLength = Math.Max(currentMaxLength, legnth);
            }


            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine(max[N]);
            }
        }

        static int CollatzLength(long num) {
            int length = 0;

            if (num == 1) {
                length = 1;
            }
            else if (num > 5000000 || cache[num] == 0) {
                length = 1 + (num % 2 == 0 ? CollatzLength(num / 2) : CollatzLength(3 * num + 1));

                if (num < 5000001) {
                    cache[num] = length;
                }
            }
            else {
                length = cache[num];
            }

            return length;

        }
    }
}
