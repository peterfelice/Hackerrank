using System;


namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++) {
                int[] bounds = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                Int64 count = 0;


                if (bounds[0] >= 0) {
                    count += countBitRange(bounds[0], bounds[1]);
                }
                else if (bounds[1] < 0) {
                    count += countBitRange(bounds[1] * -1 - 1, bounds[0] * -1 - 1);
                    count = ((bounds[1] - bounds[0] + 1l) * 32) - count;
                }
                else {
                    count += countBitRange(1, (bounds[0] + 1) * -1);
                    count = (Int64)bounds[0] * -32 - count;
                    count += countBitRange(1, bounds[1]);

                }
                Console.WriteLine(count);
            }


        }

        static Int64 countBitRange(int a, int b) {
            Int64 count = 0;

            if (a == 0 && b == 0) {
                return 0;
            }
            else if (a == 0) {
                a = 1;
            }

            for (int bit = 0; bit < 32; bit++) {
                Int64 bitPower2 = (Int64)Math.Pow(2, bit);
                Int64 bitPower2plus1 = (Int64)Math.Pow(2, bit + 1);

                Int64 positiveLowerCount = ((Int64)(bitPower2 * Math.Ceiling((a + 0.0m) / bitPower2plus1))) - Math.Min(bitPower2plus1 - ((a - 1) % bitPower2plus1) - 1, bitPower2);
                Int64 positiveUpperCount = ((Int64)(bitPower2 * Math.Ceiling((b + 1.0m) / bitPower2plus1))) - Math.Min(bitPower2plus1 - (b % bitPower2plus1) - 1, bitPower2);
                count += positiveUpperCount - positiveLowerCount;
            }
            return count;
        }

    }
}
