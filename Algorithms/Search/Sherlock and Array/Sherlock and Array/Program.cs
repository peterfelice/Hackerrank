using System;

namespace HackerRank.Algorithms.Search {
    public class SherlockandArray {
        public static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                string ans = "NO";
                int n = int.Parse(Console.ReadLine());
                int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int[] forwards = new int[A.Length];
                int[] backwards = new int[A.Length];

                forwards[0] = 0;
                backwards[A.Length - 1] = 0;
                for (int j = 1; j < A.Length; j++) {
                    forwards[j] = forwards[j - 1] + A[j - 1];
                    backwards[A.Length - j - 1] = backwards[A.Length - j] + A[A.Length - j];
                }

                for (int j = 0; j < A.Length; j++) {
                    if (forwards[j] == backwards[j]) {
                        ans = "YES";
                        break;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
