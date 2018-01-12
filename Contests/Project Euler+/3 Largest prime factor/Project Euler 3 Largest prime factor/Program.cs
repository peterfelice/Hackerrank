using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {
        Int64 numTestCases = int.Parse(Console.ReadLine());

        for (Int64 testCase = 0; testCase < numTestCases; testCase++) {
            Int64 num = Int64.Parse(Console.ReadLine());
            Int64 sqrt = (Int64)Math.Floor(Math.Sqrt(num));
            Int64 highestPrime = 0;
            for (int i = 1; i <= sqrt; i++) {
                if ((num % i) == 0) {
                    if (IsPrime(i)) {
                        highestPrime = Math.Max(highestPrime, i);
                    }
                    if (IsPrime(num / i)) {
                        highestPrime = Math.Max(highestPrime, num / i);
                    }
                }
            }

            Console.WriteLine(highestPrime);
        }

    }

    static bool IsPrime(Int64 num) {
        Int64 sqrt = (Int64)Math.Floor(Math.Sqrt(num));

        for (int i = 2; i <= sqrt; i++) {
            if ((num % i) == 0) {
                return false;
            }
        }
        return true;

    }
}