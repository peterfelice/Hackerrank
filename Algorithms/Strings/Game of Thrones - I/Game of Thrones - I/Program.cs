using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Thrones___I {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Dictionary<char, bool> map = new Dictionary<char, bool>();
            foreach (char c in input) {
                map[c] = map.ContainsKey(c) ? !map[c] : map[c] = true;
            }
            int count = map.Count(x => x.Value == true);

            Console.WriteLine(count <= 1 ? "YES" : "NO");

        }
    }
}
