using System;
using System.Linq;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testCase = 0; testCase < T; testCase++) {
                int N = int.Parse(Console.ReadLine().Trim());
                int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                int[] contArray = new int[array.Length];
                int nonContSum = int.MinValue;
                for (int i = 0; i < array.Length; i++) {
                    if (i == 0) {
                        contArray[i] = array[i];
                        nonContSum = array[i];
                        continue;
                    }

                    if (array[i] >= 0 && nonContSum >= 0) {
                        nonContSum += array[i];
                    }
                    else if (array[i] > nonContSum) {
                        nonContSum = Math.Max(array[i], nonContSum);
                    }

                    contArray[i] = Math.Max(array[i], contArray[i - 1] + array[i]);
                }


                Console.WriteLine(contArray.Max() + " " + nonContSum);
            }


        }


    }
}
