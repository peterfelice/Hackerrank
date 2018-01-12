using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine().Trim());
        long[] candies = new long[N];
        int[] ratings = new int[N];
        ratings[0] = int.Parse(Console.ReadLine().Trim());
        candies[0] = 1;

        for (int i = 1; i < N; i++) {
            ratings[i] = int.Parse(Console.ReadLine().Trim());
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
            else if (ratings[i] == ratings[i - 1]) {
                candies[i] = 1;
            }
            else if (ratings[i] < ratings[i - 1]) {
                candies[i] = 1;
                if (candies[i - 1] == 1) {
                    int count = i - 1;
                    while (count >= 0 && ratings[count] > ratings[count + 1] && candies[count] == candies[count + 1]) {
                        candies[count]++;
                        count--;
                    }
                }

            }

        }
        Console.WriteLine(candies.Sum());
    }
}