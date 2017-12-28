using System;

namespace HelperFunctions
{
    public static class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            var c = a;
            a = b;
            b = c;
        }
    }
}