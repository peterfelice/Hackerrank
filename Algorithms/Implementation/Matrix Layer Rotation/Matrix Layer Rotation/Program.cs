using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int32.Parse);
            int M = arr[0];
            int N = arr[1];
            int R = arr[2];

            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++) {
                int[] row = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int32.Parse);
                for (int j = 0; j < N; j++) {
                    matrix[i, j] = row[j];
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Tuple<int, int> tuple = RotatePoint(i, j, M, N, R);
                    Console.Write(matrix[tuple.Item1, tuple.Item2] + " ");
                }
                Console.WriteLine();
            }

        }

        static Tuple<int, int> RotatePoint(int row, int col, int M, int N, int R) {
            int ring = Math.Min(Math.Min(M - row - 1, row), Math.Min(N - col - 1, col));
            int innerM = M - 2 * ring;
            int innerN = N - 2 * ring;
            int innerR = R % (2 * (innerM + innerN) - 4);
            int currentDiff = 0;

            while (innerR > 0) {
                if (col - ring == 0 && innerR > 0) {
                    currentDiff = Math.Min(row - ring, innerR);
                    row -= currentDiff;
                    innerR -= currentDiff;
                }

                if (row - ring == innerM - 1 && innerR > 0) {
                    currentDiff = Math.Min(col - ring, innerR);
                    col -= currentDiff;
                    innerR -= currentDiff;
                }

                if (col - ring == innerN - 1 && innerR > 0) {
                    currentDiff = Math.Min((innerM - 1 - (row - ring)), innerR);
                    row += currentDiff;
                    innerR -= currentDiff;
                }

                if (row - ring == 0 && innerR > 0) {
                    currentDiff = Math.Min((innerN - 1 - (col - ring)), innerR);
                    col += currentDiff;
                    innerR -= currentDiff;
                }
            }

            return new Tuple<int, int>(row, col);
        }


    }
}
