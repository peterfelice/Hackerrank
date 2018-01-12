using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int numTestCases = int.Parse(Console.ReadLine());
        for (int cases = 0; cases < numTestCases; cases++) {
            int numLines = int.Parse(Console.ReadLine());
            int[,] triangle = new int[numLines, numLines];
            triangle[0, 0] = int.Parse(Console.ReadLine());
            for (int line = 1; line < numLines; line++) {
                string[] lineChars = Console.ReadLine().Split(' ');

                for (int i = 0; i <= line; i++) {
                    if (i > 0) {
                        triangle[line, i] = int.Parse(lineChars[i]) + Math.Max(triangle[line - 1, i - 1], triangle[line - 1, i]);
                    }
                    else {
                        triangle[line, i] = int.Parse(lineChars[i]) + triangle[line - 1, i];
                    }
                }

            }

            int max = 0;
            for (int i = 0; i < numLines; i++) {
                max = Math.Max(max, triangle[numLines - 1, i]);
            }
            Console.WriteLine(max);
        }
    }
}