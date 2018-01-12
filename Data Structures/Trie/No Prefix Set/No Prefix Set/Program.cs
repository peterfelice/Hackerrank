using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Run(args);
    }

    public static void Run(String[] args) {
        int N = int.Parse(Console.ReadLine());

        Trie trie = new Trie();
        for (int i = 0; i < N; i++) {
            string word = Console.ReadLine().Trim();
            string answer = trie.Add(word);
            if (!String.IsNullOrEmpty(answer)) {
                Console.WriteLine("BAD SET");
                Console.WriteLine(answer);
                return;
            }
        }
        Console.WriteLine("GOOD SET");
    }
    public class Trie {
        class TrieNode {
            public TrieNode[] Children { get; set; }
            public bool IsLeaf { get; set; }
            public int Count { get; set; }

            public TrieNode() {
                Children = new TrieNode[26];
                IsLeaf = false;
                Count = 0;
            }
        }

        private TrieNode root { get; set; }

        public Trie() {
            root = new TrieNode();
        }


        public string Add(string word) {
            string originalWord = word;
            TrieNode currentNode = root;
            currentNode.Count++;
            while (!String.IsNullOrEmpty(word)) {
                char firstChar = word[0];
                if (currentNode.Children[firstChar - 'a'] == null) {
                    currentNode.Children[firstChar - 'a'] = new TrieNode();
                }
                word = word.Substring(1);
                currentNode = currentNode.Children[firstChar - 'a'];
                currentNode.Count++;

                if (currentNode.IsLeaf && currentNode.Count > 1) {
                    return originalWord;
                }
            };

            currentNode.IsLeaf = true;
            if (currentNode.Count > 1) {
                return originalWord;
            }

            return String.Empty;
        }

        public int Find(string prefix) {
            TrieNode currentNode = root;
            while (!String.IsNullOrEmpty(prefix)) {
                char firstChar = prefix[0];
                if (currentNode.Children[firstChar - 'a'] == null) {
                    return 0;
                }
                prefix = prefix.Substring(1);
                currentNode = currentNode.Children[firstChar - 'a'];
            }
            return currentNode.Count;
        }
    }


}