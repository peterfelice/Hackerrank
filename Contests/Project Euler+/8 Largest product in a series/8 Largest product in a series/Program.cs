using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {

        int T = int.Parse(Console.ReadLine().Trim());

        for (int testcase = 0; testcase < T; testcase++) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int K = arr[1];
            string[] nums = Console.ReadLine().Trim().Split('0');

            int maxProduct = 0;

            foreach (string stringNum in nums) {
                if (stringNum.Length >= K) {
                    int product = 0;
                    int[] num = Array.ConvertAll(stringNum.ToCharArray(), Convert.ToInt32);

                    for (int i = 0; i < num.Length; i++) {
                        num[i] -= '0';
                    }

                    for (int i = 0; i < K; i++) {
                        product = i == 0 ? num[i] : product * num[i];
                    }

                    maxProduct = Math.Max(product, maxProduct);

                    for (int i = K; i < num.Length; i++) {
                        product = product / num[i - K] * num[i];
                        maxProduct = Math.Max(product, maxProduct);
                    }
                }
            }
            Console.WriteLine(maxProduct);
        }
    }
}