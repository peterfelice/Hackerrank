using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank {
    class Solution {


        private static void Main(string[] args) {
            long[] nc = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
            long N = nc[0];
            long C = nc[1];
            long[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);

            int start;
            long fuel = 0;
            for (start = 0; start < N; start++) {
                fuel = 0;
                for (int i = 0; i < N; i++) {
                    long index = (start + i) % N;
                    fuel = Math.Min(fuel + a[index], C) - b[index];
                    if (fuel < 0) {
                        start = start + i;
                        break;
                    }
                }
                if (fuel >= 0) {
                    break;
                }
            }

            if (fuel < 0) {
                Console.WriteLine(0);
                return;
            }
            long count = 1;
            long[] need = new long[N];
            need[start] = 0;
            for (int i = 1; i < N; i++) {
                long index = (start - i + N) % N;
                need[index % N] = Math.Max(need[(index + 1) % N] + Math.Min(b[index % N] - a[index % N], C), 0);
                if (need[index] == 0) {
                    count++;
                }
            }

            Console.WriteLine(count);


        }
    }
}
