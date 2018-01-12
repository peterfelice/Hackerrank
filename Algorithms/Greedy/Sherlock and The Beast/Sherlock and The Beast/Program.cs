using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock {
    class Program {
        static void Main(string[] args) {
            int numCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCases; i++) {
                int length = int.Parse(Console.ReadLine());
                int fives = length - (length % 3);
                bool possible = false;
                for (int j = 0; j <= 3; j++) {
                    if ((length - fives) % 5 == 0) {
                        possible = true;
                        break;
                    }
                    else if (fives == 0) {
                        break;
                    }
                    else {
                        fives = fives - 3;
                    }
                }
                if (possible) {
                    StringBuilder sb = new StringBuilder(length);
                    for (int j = 0; j < length; j++) {
                        if (j < fives) sb.Append(5);
                        else sb.Append(3);
                    }
                    Console.WriteLine(sb);
                }
                else {
                    Console.WriteLine(-1);
                }
            }

        }
    }
}
