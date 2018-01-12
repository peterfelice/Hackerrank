using System;


namespace MaxMin {
    class Program {
        static void Main(string[] args) {
            int numBags = int.Parse(Console.ReadLine());
            int numChildren = int.Parse(Console.ReadLine());
            int[] canideBags = new int[numBags];
            int unfairness = int.MaxValue;

            for (int i = 0; i < numBags; i++) {
                canideBags[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(canideBags);

            for (int i = 0; i < numBags - numChildren; i++) {
                unfairness = Math.Min(unfairness, canideBags[i + numChildren - 1] - canideBags[i]);
            }

            Console.WriteLine(unfairness);
        }
    }
}
