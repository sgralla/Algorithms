using System;
using HelperFunctions;

namespace SortAlgorithms
{
    public static class Sort
    {
        public static void Bubble1(int[] sortingArray)
        {   
//            for (n=A.size; n>1; n=n-1){
//                for (i=0; i<n-1; i=i+1){
//                    if (A[i] > A[i+1]){
//                        A.swap(i, i+1)
//                    } // ende if
//                } // ende innere for-Schleife
//            } // ende äußere for-Schleife

            for (var i = sortingArray.Length; i > 1; i--)
            {
                for (var j = 0; j < i - 1; j++)
                {
                    if (sortingArray[j] > sortingArray[j + 1])
                    {
                        Helper.Swap(ref sortingArray[j], ref sortingArray[j + 1]);
                    }
                }
            }
    
        }
        
        public static void Bubble2(int[] sortingArray)
        {   
//            n = A.size
//            do{
//                swapped = false
//                for (i=0; i<n-1; ++i){
//                    if (A[i] > A[i+1]){
//                        A.swap(i, i+1)
//                        swapped = true
//                    } // ende if
//                } // ende for
//                n = n-1
//            } while (swapped)

            bool swapped;
            do
            {
                swapped = false;
                for (var i = 0; i < sortingArray.Length - 1; i++)
                {
                   if (sortingArray[i] <= sortingArray[i + 1]) continue;
                    Helper.Swap(ref sortingArray[i], ref sortingArray[i + 1]);
                    swapped = true;
                }

            } while (swapped);

        }
        
        public static void Bubble3(int[] sortingArray)
        {   
//        n = A.size
//            do{
//                newn = 1
//                for (i=0; i<n-1; ++i){
//                    if (A[i] > A[i+1]){
//                        A.swap(i, i+1)
//                        newn = i+1
//                    } // ende if
//                } // ende for
//                n = newn
//            } while (n > 1)

            var n = sortingArray.Length;
            do
            {
                var tempn = 1;
                for (var i = 0 ; i < n - 1; ++i)
                {
                    
                    if (sortingArray[i] <= sortingArray[i + 1]) continue;
                    Helper.Swap(ref sortingArray[i], ref sortingArray[i + 1]);
                    tempn += 1;
                }
                n = tempn;


            } while (n > 1);

        }
    }
}