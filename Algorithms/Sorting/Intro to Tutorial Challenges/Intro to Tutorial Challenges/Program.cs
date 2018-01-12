using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int v = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

        for (int i = 0; i < n; i++) {
            if (arr[i] == v) {
                Console.WriteLine(i);
            }
        }
    }
}