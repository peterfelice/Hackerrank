using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank {
    class Solution {


        private static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine().Trim());

            for (int testcase = 0; testcase < T; testcase++) {
                string S = Console.ReadLine().Trim();
                Dictionary<string, int> cache = new Dictionary<string, int>();

                for (int i = 0; i < S.Length; i++) {
                    for (int j = i; j < S.Length; j++) {
                        string temp = string.Concat(S.Substring(i, j - i + 1).OrderBy(c => c));
                        if (cache.ContainsKey(temp)) {
                            cache[temp]++;
                        }
                        else {
                            cache.Add(temp, 1);
                        }

                    }
                }

                int count = 0;
                foreach (string key in cache.Keys) {
                    count += cache[key] * (cache[key] - 1) / 2;
                }

                Console.WriteLine(count);
            }

        }
    }
}
