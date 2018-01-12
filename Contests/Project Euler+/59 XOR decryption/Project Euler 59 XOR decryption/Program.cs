using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        int numChars = int.Parse(Console.ReadLine());
        string[] characters = Console.ReadLine().Split(' ');
        int[] keys = new int[3];


        string regexPat = @"[A-Za-z0-9\(\)\;\:\,\.\'\?\-\! ]";
        Regex regex = new Regex(regexPat);

        bool pass = false;
        for (int first = 97; first <= 122; first++) {
            keys[0] = first;
            for (int second = 97; second <= 122; second++) {
                keys[1] = second;
                for (int third = 97; third <= 122; third++) {
                    keys[2] = third;
                    int index = 0;
                    pass = true;

                    foreach (string character in characters) {
                        string decryptedChar = ((char)(int.Parse(character) ^ keys[index])).ToString();
                        MatchCollection matches = regex.Matches(decryptedChar);
                        if (matches.Count == 0) {
                            pass = false;
                            break;
                        }
                        index = (index + 1) % 3;
                    }
                    if (pass) {
                        break;
                    }
                }
                if (pass) {
                    break;
                }

            }
            if (pass) {
                break;
            }
        }
        Console.WriteLine("" + (char)keys[0] + (char)keys[1] + (char)keys[2]);
    }
}