using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV03
{
    #region ex3
    //public delegate bool sortingfunDelegate(int A, int B);
    //internal class Sortingalgorithm
    //{
    //    #region ex2
    //    //    public static void BubblesortAscending(int [] Arr)
    //    //    {
    //    //        if (Arr?.Length > 0)
    //    //        {
    //    //            for (int i = 0; i < Arr.Length; i++) 
    //    //            { 
    //    //            for(int j = 0;j<Arr.Length-i-1;j++)
    //    //                {
    //    //                    //if (Arr[j] > Arr[j+1])
    //    //                    //    Swap(ref Arr[j], ref Arr[j+1]);
    //    //                    if (Sortingcondition.comparegtr(Arr[j], Arr[j + 1])) ;
    //    //                    Swap(ref Arr[j], ref Arr[j + 1]);
    //    //                }
    //    //            }

    //    //        }
    //    //    }
    //    //public static void BubblesortSDscending(int[] Arr)
    //    //{
    //    //    if (Arr?.Length > 0)
    //    //    {
    //    //        for (int i = 0; i < Arr.Length; i++)
    //    //        {
    //    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //            {
    //    //                //if (Arr[j] < Arr[j + 1])
    //    //                //    Swap(ref Arr[j], ref Arr[j + 1]);
    //    //                if (Sortingcondition.compareless(Arr[j], Arr[j + 1])) ;

    //    //            }
    //    //        }

    //    //    }
    //    //}
    //    //    private static void Swap(ref int x, ref int y) 
    //    //    {
    //    //        int temp = x;
    //    //        x = y;
    //    //        y=temp;

    //    //    } 
    //    #endregion

    //    public static void Bubblesort(int[] Arr, sortingfunDelegate reference)
    //    {
    //        if (Arr?.Length > 0)
    //        {
    //            for (int i = 0; i < Arr.Length; i++)
    //            {
    //                for (int j = 0; j < Arr.Length - i - 1; j++)
    //                {
    //                    if (reference.Invoke(Arr[j], Arr[i + 1])) ;
    //                    Swap(ref Arr[j], ref Arr[j + 1]);
    //                }
    //            }

    //        }
    //    }
    //    private static void Swap(ref int x, ref int y)
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;

    //    }
    //} 
    #endregion


}




