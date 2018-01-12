using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Search {
    public class ConnectedCellsInAGrid {
        public static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n + 2][];
            matrix[0] = new int[m + 2];
            matrix[n + 1] = new int[m + 2];
            for (int i = 1; i <= n; i++) {
                matrix[i] = Array.ConvertAll(("0 " + Console.ReadLine() + " 0").Split(' '), int.Parse);
            }

            int maxCount = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (matrix[i][j] == 0) {
                        continue;
                    }
                    else {
                        int count = 1;
                        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
                        queue.Enqueue(new Tuple<int, int>(i, j));
                        matrix[i][j] = 0;
                        while (queue.Count > 0) {
                            Tuple<int, int> currentNode = queue.Dequeue();
                            for (int y = -1; y <= 1; y++) {
                                for (int z = -1; z <= 1; z++) {
                                    if (matrix[currentNode.Item1 + y][currentNode.Item2 + z] == 1) {
                                        queue.Enqueue(new Tuple<int, int>(currentNode.Item1 + y, currentNode.Item2 + z));
                                        matrix[currentNode.Item1 + y][currentNode.Item2 + z] = 0;
                                        count++;
                                    }
                                }
                            }
                        }

                        maxCount = Math.Max(maxCount, count);
                    }

                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
