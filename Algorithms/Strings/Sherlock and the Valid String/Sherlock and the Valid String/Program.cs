using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            foreach (char c in input) {
                if (!lookup.ContainsKey(c)) {
                    lookup.Add(c, 0);
                }
                lookup[c]++;
            }

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int count in lookup.Values) {
                if (!counts.ContainsKey(count)) {
                    counts.Add(count, 0);
                }
                counts[count]++;
            }

            if (counts.Count == 1 || counts.Count == 2 && counts.Values.Any(x => x == 1)) {
                Console.WriteLine("YES");
            }
            else {
                Console.WriteLine("NO");
            }

        }
    }
}
