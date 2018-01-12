using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank {
    class Solution {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine().Trim());
            StringBuilder ans = new StringBuilder();
            Stack<string> undoStack = new Stack<string>();

            for (int i = 0; i < N; i++) {
                string[] command = Console.ReadLine().Trim().Split(' ');
                if (command[0] == "1") {
                    undoStack.Push(ans.ToString());
                    ans.Append(command[1]);
                }
                else if (command[0] == "2") {
                    int k = int.Parse(command[1]);
                    undoStack.Push(ans.ToString());
                    ans.Remove(ans.Length - k, k);
                }
                else if (command[0] == "3") {
                    int k = int.Parse(command[1]);
                    Console.WriteLine(ans[k - 1]);
                }
                else if (command[0] == "4") {
                    ans = new StringBuilder(undoStack.Pop());
                }

            }
        }
    }
}
