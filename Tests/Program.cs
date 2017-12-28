using System;
using System.Collections.Generic;
using MathAlgorithms;
using SortAlgorithms;

namespace Tests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BubbleSort_Test();
        }

        public static void Euclidian_Test()
        {
            var a = new[] {1024, 768, 0};

            Euclidian.GreatestCommonDenominator(a);
            Console.WriteLine(a[1]);
        }

        public static void BubbleSort_Test()
        {
            var a = new[] {3, 3, 1, 2, 4, 5, 6, 3, 2, 444, 6, 4};
            Sort.Bubble3(a);
            foreach (var v in a)
            {
                Console.WriteLine(v);
            }
        }
    }
}