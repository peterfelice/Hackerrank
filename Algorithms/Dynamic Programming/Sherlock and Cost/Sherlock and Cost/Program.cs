using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DynamicProgramming.Search {
    public class SherlockAndCost {
        public static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++) {
                int N = int.Parse(Console.ReadLine());
                int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int[] highSum = new int[B.Length];
                highSum[0] = 0;
                int[] lowSum = new int[B.Length];
                lowSum[0] = 0;

                for (int i = 1; i < B.Length; i++) {
                    highSum[i] = Math.Max(highSum[i - 1] + Math.Abs(B[i] - B[i - 1]), lowSum[i - 1] + Math.Abs(B[i] - 1));
                    lowSum[i] = highSum[i - 1] + Math.Abs(B[i - 1] - 1);
                }

                Console.WriteLine(Math.Max(highSum[B.Length - 1], lowSum[B.Length - 1]));
            }

        }
    }
}

