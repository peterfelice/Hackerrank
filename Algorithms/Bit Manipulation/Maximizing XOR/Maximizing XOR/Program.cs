using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int L = Int32.Parse(Console.ReadLine());
        int R = Int32.Parse(Console.ReadLine());

        int bitmask = 1 << 30;
        int ans = Int32.MaxValue;

        for (int i = 0; i < 32; i++) {
            if ((bitmask & L) != (bitmask & R)) {
                break;
            }
            ans >>= 1;
            bitmask >>= 1;
        }

        Console.WriteLine(ans);

    }
}