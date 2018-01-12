using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int[,] counts = new int[a.Length, b.Length];

            for (int i = 0; i < a.Length; i++) {
                for (int j = 0; j < b.Length; j++) {
                    if (i == 0 || j == 0) {
                        counts[i, j] = 0;
                    }
                    else {
                        counts[i, j] = counts[i - 1, j - 1];
                    }

                    if (a[i] == b[j]) {
                        counts[i, j]++;
                    }

                    if (i != 0 && counts[i - 1, j] > counts[i, j]) {
                        counts[i, j] = counts[i - 1, j];
                    }

                    if (j != 0 && counts[i, j - 1] > counts[i, j]) {
                        counts[i, j] = counts[i, j - 1];
                    }
                }
            }
            int max = 0;
            for (int i = 0; i < a.Length; i++) {
                max = Math.Max(Math.Max(counts[i, a.Length - 1], counts[a.Length - 1, i]), max);
            }
            Console.WriteLine(max);
        }
    }
}
