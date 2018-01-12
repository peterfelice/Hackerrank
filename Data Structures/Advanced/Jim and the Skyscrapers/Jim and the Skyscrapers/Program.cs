using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            Stack<int> stack = new Stack<int>();
            long count = 0;
            int repeat = 0;
            int lastHeight = -1;

            foreach (int currentHeight in array) {
                if (stack.Count == 0 || currentHeight <= stack.Peek()) {
                    stack.Push(currentHeight);
                    continue;
                }

                repeat = 0;
                lastHeight = -1;
                while (stack.Count > 0 && currentHeight > stack.Peek()) {
                    int newHeight = stack.Pop();
                    if (lastHeight == newHeight) {
                        repeat++;
                    }
                    else {
                        count += repeat * (repeat + 1L) / 2;
                        repeat = 0;
                    }
                    lastHeight = newHeight;
                }
                count += repeat * (repeat + 1L) / 2;

                stack.Push(currentHeight);

            }

            if (stack.Count > 0) {
                repeat = 0;
                lastHeight = stack.Pop();
                while (stack.Count > 0) {
                    int newHeight = stack.Pop();
                    if (lastHeight == newHeight) {
                        repeat++;
                    }
                    else {
                        count += repeat * (repeat + 1L) / 2;
                        repeat = 0;
                    }
                    lastHeight = newHeight;
                }
                count += repeat * (repeat + 1L) / 2;
            }
            Console.WriteLine(count * 2);
        }
    }
}
