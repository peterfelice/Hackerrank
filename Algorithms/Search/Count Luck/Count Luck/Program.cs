using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Search {
    public class CountLuck {
        public static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine());

            for (int testCases = 0; testCases < T; testCases++) {
                int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = NM[0];
                int M = NM[1];

                StringBuilder[] grid = new StringBuilder[N + 2];
                int startingN = 0;
                int startingM = 0;
                grid[0] = new StringBuilder(new string('X', M + 2));
                grid[N + 1] = new StringBuilder(new string('X', M + 2));
                for (int i = 1; i <= N; i++) {
                    grid[i] = new StringBuilder("X" + Console.ReadLine() + "X");
                    if ((grid[i].ToString().IndexOf("M")) >= 0) {
                        startingM = grid[i].ToString().IndexOf("M");
                        startingN = i;
                    }

                }
                int K = int.Parse(Console.ReadLine());

                Queue<Tuple<int, int, int>> queue = new Queue<Tuple<int, int, int>>();
                queue.Enqueue(new Tuple<int, int, int>(startingN, startingM, 0));

                Tuple<int, int, int> currentNode = new Tuple<int, int, int>(0, 0, 0);
                while (queue.Count > 0) {
                    currentNode = queue.Dequeue();
                    if (grid[currentNode.Item1][currentNode.Item2] == '*') {
                        break;
                    }
                    grid[currentNode.Item1][currentNode.Item2] = 'M';

                    List<Tuple<int, int>> newNodes = new List<Tuple<int, int>>();
                    int possibleWays = 0;
                    if (grid[currentNode.Item1 - 1][currentNode.Item2] == '.' || grid[currentNode.Item1 - 1][currentNode.Item2] == '*') {
                        possibleWays++;
                        newNodes.Add(new Tuple<int, int>(currentNode.Item1 - 1, currentNode.Item2));
                    }
                    if (grid[currentNode.Item1 + 1][currentNode.Item2] == '.' || grid[currentNode.Item1 + 1][currentNode.Item2] == '*') {
                        possibleWays++;
                        newNodes.Add(new Tuple<int, int>(currentNode.Item1 + 1, currentNode.Item2));
                    }
                    if (grid[currentNode.Item1][currentNode.Item2 - 1] == '.' || grid[currentNode.Item1][currentNode.Item2 - 1] == '*') {
                        possibleWays++;
                        newNodes.Add(new Tuple<int, int>(currentNode.Item1, currentNode.Item2 - 1));
                    }
                    if (grid[currentNode.Item1][currentNode.Item2 + 1] == '.' || grid[currentNode.Item1][currentNode.Item2 + 1] == '*') {
                        possibleWays++;
                        newNodes.Add(new Tuple<int, int>(currentNode.Item1, currentNode.Item2 + 1));
                    }

                    int count = possibleWays > 1 ? currentNode.Item3 + 1 : currentNode.Item3;
                    foreach (Tuple<int, int> tuple in newNodes) {
                        queue.Enqueue(new Tuple<int, int, int>(tuple.Item1, tuple.Item2, count));
                    }
                }

                Console.WriteLine(currentNode.Item3 == K ? "Impressed" : "Oops!");
            }
        }
    }
}
