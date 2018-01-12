using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string sentence = Console.ReadLine();
        sentence = sentence.ToLower();
        bool[] found = new bool[26];
        int count = 0;
        foreach (char c in sentence) {
            if (c >= 'a' && c <= 'z' && !found[c - 'a']) {
                found[c - 'a'] = true;
                count++;
                if (count == 26) {
                    break;
                }
            }
        }
        if (count != 26) {
            Console.Write("not ");
        }
        Console.WriteLine("pangram");

    }
}