using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args) {
        int T = int.Parse(Console.ReadLine());
        Random r = new Random();

        int currentPal;
        List<int> list = new List<int>(900);
        for (int i = 1; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                for (int k = 0; k < 10; k++) {
                    currentPal = i * 100000 + j * 10000 + k * 1100 + j * 10 + i;
                    if (IsProductOf3DigitNumbers(currentPal)) {
                        list.Add(currentPal);
                    }
                }
            }
        }

        for (int testCase = 0; testCase < T; testCase++) {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            foreach (int i in list) {
                if (i > n) {
                    break;
                }
                ans = i;
            }
            Console.WriteLine(ans);
        }

    }

    static bool IsProductOf3DigitNumbers(int num) {
        for (int i = 100; i < 1000; i++) {
            if (num % i == 0 && num / i < 1000) {
                return true;
            }
        }

        return false;
    }
}