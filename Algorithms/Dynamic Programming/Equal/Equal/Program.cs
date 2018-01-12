using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++) {
            int minSum = int.MaxValue;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] persons_s = Console.ReadLine().Split(' ');
            int[] persons = Array.ConvertAll(persons_s, Int32.Parse);
            int min = persons.Min();
            if (min < 4) {
                for (int count = 0; count < n; count++) {
                    persons[count] += (4 - min);
                }
                min = 4;
            }

            for (int count = 0; count < 5; count++) {
                int sum = 0;
                foreach (int val in persons) {
                    int diff = val - (min - count);
                    sum += diff / 5;
                    diff %= 5;
                    sum += diff / 2;
                    diff %= 2;
                    sum += diff;
                }
                minSum = sum < minSum ? sum : minSum;
            }
            Console.WriteLine(minSum);
        }



    }
}
