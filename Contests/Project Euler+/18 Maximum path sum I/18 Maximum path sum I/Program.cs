using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {


        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());

                int[][] triangle = new int[N][];
                int[] sums = new int[N * (N - 1) / 2];
                for (int row = 0; row < N; row++) {
                    triangle[row] = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                }


                if (N == 1) {
                    Console.WriteLine(triangle[0][0]);
                    continue;
                }


                for (int row = N - 2; row >= 0; row--) {
                    for (int pos = 0; pos <= row; pos++) {
                        int index = row * (row + 1) / 2 + pos;
                        if (row == N - 2) {
                            sums[index] = triangle[row][pos] + Math.Max(triangle[row + 1][pos], triangle[row + 1][pos + 1]);
                        }
                        else {
                            sums[index] = triangle[row][pos] + Math.Max(sums[index + row + 1], sums[index + row + 2]);
                        }
                    }
                }

                Console.WriteLine(sums[0]);
            }
        }
    }
}
