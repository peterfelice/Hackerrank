using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Int64 numTestCases = int.Parse(Console.ReadLine());


        for (Int64 testCase = 0; testCase < numTestCases; testCase++) {
            Int64 num = Int64.Parse(Console.ReadLine()) - 1;
            Decimal sum3 = 3 * (num / 3 * ((num / 3) + 1));
            Decimal sum5 = 5 * (num / 5 * ((num / 5) + 1));
            Decimal sum15 = 15 * (num / 15 * ((num / 15) + 1));
            Console.WriteLine((sum3 + sum5 - sum15) / 2);

        }
    }
}