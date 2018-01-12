using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank {
    class Solution {

        private static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine().Trim());

            int[] graphs = new int[2 * N + 1];
            int currentBucket = 1;

            for (int i = 0; i < N; i++) {
                int[] edge = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

                if (graphs[edge[0]] != 0 && graphs[edge[1]] != 0 && graphs[edge[0]] != graphs[edge[1]]) {
                    int tempBucket = graphs[edge[1]];
                    for (int index = 0; index < 2 * N + 1; index++) {
                        if (graphs[index] == tempBucket) {
                            graphs[index] = graphs[edge[0]];
                        }
                    }
                }
                else if (graphs[edge[0]] != 0 && graphs[edge[1]] == 0) {
                    graphs[edge[1]] = graphs[edge[0]];
                }
                else if (graphs[edge[0]] == 0 && graphs[edge[1]] != 0) {
                    graphs[edge[0]] = graphs[edge[1]];
                }
                else if (graphs[edge[0]] == 0 && graphs[edge[1]] == 0) {
                    graphs[edge[0]] = currentBucket;
                    graphs[edge[1]] = currentBucket;
                    currentBucket++;
                }
            }
            var groupings = graphs.Where(x => x != 0).GroupBy(x => x);
            int min = groupings.Min(x => x.Count());
            int max = groupings.Max(x => x.Count());

            Console.WriteLine(min + " " + max);
        }
    }
}
