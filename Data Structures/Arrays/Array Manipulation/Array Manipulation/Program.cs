using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        int N = NM[0];
        int M = NM[1];

        int[] array = new int[N + 1];
        for (int i = 0; i < M; i++) {
            int[] abk = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int a = abk[0];
            int b = abk[1];
            int k = abk[2];

            array[a - 1] += k;
            array[b] -= k;
        }
        Int64 max = array[0];
        Int64 counter = array[0];
        for (int i = 1; i < N; i++) {
            counter += array[i];
            max = Math.Max(max, counter);
        }

        Console.WriteLine(max);
    }
}