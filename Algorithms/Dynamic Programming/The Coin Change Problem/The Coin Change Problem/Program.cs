using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int32.Parse);
            int N = arr[0];
            int M = arr[1];
            Dictionary<string, long> lut = new Dictionary<string, long>();
            int[] coins = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int32.Parse).OrderBy(x => x).ToArray();
            long num = NumberOfWays(N, coins, lut);
            Console.WriteLine(num);
        }

        static long NumberOfWays(int N, int[] coins, Dictionary<string, long> lut) {
            long sum = 0;
            int currentCoin = coins.Last();
            if (lut.ContainsKey(N + ":" + currentCoin)) {
                return lut[N + ":" + currentCoin];
            }
            int[] remainingCoins = coins.Take(coins.Length - 1).ToArray();
            for (int i = 0; i < (N / currentCoin) + 1; i++) {
                if ((i * currentCoin) == N) {
                    sum++;
                }
                else {
                    if (remainingCoins.Length != 0) {
                        sum += NumberOfWays(N - (i * currentCoin), remainingCoins, lut);
                    }
                }
            }

            lut.Add(N + ":" + currentCoin, sum);
            return sum;
        }


    }
}
