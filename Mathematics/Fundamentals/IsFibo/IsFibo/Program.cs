using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    private static List<Int64> _fibonacciSeries = new List<Int64>();
    
    static Solution() {
        _fibonacciSeries.Add(0);
        _fibonacciSeries.Add(1);

    }

    static void IsFibonacci(Int64 testCase) {
        while (testCase > _fibonacciSeries.Last()) {
            int count = _fibonacciSeries.Count;
            _fibonacciSeries.Add(_fibonacciSeries[count - 1] + _fibonacciSeries[count - 2]);
        }

        Console.WriteLine(_fibonacciSeries.Contains(testCase) ? "IsFibo" : "IsNotFibo");
    }

        static void Main(String[] args) {
        Int64 testCases = Int64.Parse(Console.ReadLine());

        for (Int64 i = 0; i < testCases; i++) {
            Int64 testCase = Int64.Parse(Console.ReadLine());
            IsFibonacci(testCase);
        }
    }
}