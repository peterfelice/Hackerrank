using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Contacts.Run(args);
    }

    public static class Contacts {

        public static void Run(String[] args) {
            int N = int.Parse(Console.ReadLine());

            Trie trie = new Trie();
            for (int i = 0; i < N; i++) {
                string[] command = Console.ReadLine().Trim().Split(new[] { ' ' });
                if (command[0] == "add") {
                    trie.Add(command[1]);
                }
                else {
                    Console.WriteLine(trie.Find(command[1]));
                }
            }

        }

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


        public void Add(string word) {
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
            };

            currentNode.IsLeaf = true;
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