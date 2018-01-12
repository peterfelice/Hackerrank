using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {
        int T = int.Parse(Console.ReadLine().Trim());

        for (int testcase = 0; testcase < T; testcase++) {
            int N = int.Parse(Console.ReadLine().Trim());
            if (N == 1) {
                Console.WriteLine(0);
                continue;
            }

            Decimal forumla = (1m * (N * (N + 1)) * (3 * (N * (N + 1)) - 2 * (2 * N + 1))) / 12;
            Console.WriteLine(forumla);
        }
    }

}