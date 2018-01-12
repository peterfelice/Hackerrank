using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Search {
    public class BeautifulQuadruples {
        public static void Main(string[] args) {
            int[] ABCD = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(ABCD);
            int A = ABCD[0];
            int B = ABCD[1];
            int C = ABCD[2];
            int D = ABCD[3];

            long count = 0;
            long[] totals = new long[3001];
            long[,] xors = new long[3001, 4097];
            for (int a = 1; a <= A; a++) {
                for (int b = a; b <= B; b++) {
                    totals[b]++;
                }
            }

            for (int i = 1; i < 3001; i++) {
                totals[i] += totals[i - 1];
            }

            for (int a = 1; a <= A; a++) {
                for (int b = a; b <= B; b++) {
                    xors[b, a ^ b]++;
                }
            }

            for (int i = 0; i < 4097; i++) {
                for (int j = 1; j < 3001; j++) {
                    xors[j, i] += xors[j - 1, i];
                }
            }

            for (int c = 1; c <= C; c++) {
                for (int d = c; d <= D; d++) {
                    count += totals[c] - xors[c, c ^ d];
                }
            }

            Console.WriteLine(count);

        }
    }
}

