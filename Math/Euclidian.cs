using System;

namespace MathAlgorithms
{
    public static class Euclidian
    {
        public static int GreatestCommonDenominator(int a, int b)
        {
            var c = new[] {a, b, 0};
            GreatestCommonDenominator(c);
            return c[2];
        }

        public static void GreatestCommonDenominator(int[] a)
        {
            a[2] = a[0] % a[1];
            
            while (a[2] > 0)
            {
                Array.Copy(a, 1, a, 0, 2);
                a[2] = a[0] % a[1];
            }
        }
        
    }
}