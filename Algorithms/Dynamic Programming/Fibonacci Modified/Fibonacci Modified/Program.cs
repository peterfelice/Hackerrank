using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution {

    static void Main(String[] args) {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        BigInteger A = inputs[0];
        BigInteger B = inputs[1];
        int N = inputs[2];

        BigInteger temp;
        for (int i = 2; i < N; i++) {
            temp = B;
            B = B * B + A;
            A = temp;
        }

        Console.WriteLine(B);

    }
}
