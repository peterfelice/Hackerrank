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
            int area = 0;
            int topIndex;
            int currentArea;
            for (int i = 0; i < N; i++) {
                if (stack.Count == 0 || array[stack.Peek()] <= array[i]) {
                    stack.Push(i);
                    continue;
                }

                while (stack.Count > 0 && array[stack.Peek()] > array[i]) {
                    topIndex = stack.Pop();
                    currentArea = array[topIndex] * (stack.Count == 0 ? i : i - stack.Peek() - 1);
                    area = currentArea > area ? currentArea : area;
                }
                stack.Push(i);
            }

            while (stack.Count > 0) {
                topIndex = stack.Pop();
                currentArea = array[topIndex] * (stack.Count == 0 ? N : N - stack.Peek() - 1);
                area = currentArea > area ? currentArea : area;
            }

            Console.WriteLine(area);
        }
    }
}
