using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int N = Int32.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        Stack<int> values = new Stack<int>();
        int max = 0;
        for (int i = 0; i < N; i++) {
            while (values.Count > 0) {
                max = Math.Max(max, array[i] ^ values.Peek());
                if (array[i] < values.Peek()) {
                    values.Pop();
                }
                else {
                    break;
                }
            }

            values.Push(array[i]);

        }
        Console.WriteLine(max);
    }
}