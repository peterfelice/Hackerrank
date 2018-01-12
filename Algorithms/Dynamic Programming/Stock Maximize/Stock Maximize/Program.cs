using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution {



    static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine().Trim());
        for (int testCase = 0; testCase < T; testCase++) {
            int N = int.Parse(Console.ReadLine().Trim());

            int[] prices = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int max = int.MinValue;
            long profit = 0;

            for (int i = prices.Length - 1; i >= 0; i--) {
                if (prices[i] > max) {
                    max = prices[i];
                }
                else {
                    profit += max - prices[i];
                }
            }

            Console.WriteLine(profit);
        }

    }
}
