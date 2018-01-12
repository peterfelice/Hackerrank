using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram {
    class Program {
        static void Main(string[] args) {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++) {
                string words = Console.ReadLine();
                if (words.Length % 2 == 1) {
                    Console.WriteLine(-1);
                }
                else {
                    string word1 = words.Substring(0, words.Length / 2);
                    string word2 = words.Substring(words.Length / 2);
                    Dictionary<char, int> map = new Dictionary<char, int>();
                    foreach (char c in word2) {
                        map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;
                    }
                    foreach (char c in word1) {
                        map[c] = map.ContainsKey(c) ? map[c] - 1 : -1;
                    }

                    Console.WriteLine(map.Sum(x => Math.Max(x.Value, 0)));

                }
            }
        }
    }
}
