using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {
        int T = int.Parse(Console.ReadLine());

        for (int testCase = 0; testCase < T; testCase++) {
            Dictionary<int, int> ladders = new Dictionary<int, int>();
            Dictionary<int, int> snakes = new Dictionary<int, int>();
            int[] squares = new int[101];
            for (int i = 0; i < squares.Length; i++) {
                squares[i] = int.MaxValue;
            }

            int numLadders = int.Parse(Console.ReadLine());
            for (int i = 0; i < numLadders; i++) {
                int[] ladder = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                ladders.Add(ladder[0], ladder[1]);
            }
            int numSnakes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSnakes; i++) {
                int[] snake = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                snakes.Add(snake[0], snake[1]);
            }

            squares[1] = 0;
            for (int i = 2; i < 101; i++) {
                int lookBack = Math.Min(6, i - 1);
                bool isChanged = false;
                for (int j = i - lookBack; j < i; j++) {
                    if (squares[i] > squares[j] + 1 && !snakes.ContainsKey(j)) {
                        squares[i] = squares[j] + 1;
                        isChanged = true;
                    }
                }
                if (ladders.ContainsKey(i) && isChanged) {
                    squares[ladders[i]] = squares[i];
                }

                if (snakes.ContainsKey(i) && isChanged) {
                    squares[snakes[i]] = squares[i];
                    i = snakes[i] + 1;
                }

            }
            if (squares[100] == int.MaxValue) {
                squares[100] = -1;
            }
            Console.WriteLine(squares[100]);

        }

    }


}