using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Int64 numTestCases = int.Parse(Console.ReadLine());
        Int64[] fibs = new Int64[82];
        fibs[0] = 1;
        fibs[1] = 1;

        for (int i = 2; i < fibs.Length; i++) {
            fibs[i] = fibs[i - 2] + fibs[i - 1];
        }


        for (Int64 testCase = 0; testCase < numTestCases; testCase++) {
            Int64 num = Int64.Parse(Console.ReadLine()) - 1;
            Int64 sum = 0;
            int count = 0;
            while (fibs[count] < num) {
                if (fibs[count] % 2 == 0) {
                    sum += fibs[count];
                }
                count++;
            }

            Console.WriteLine(sum);
        }
    }
}