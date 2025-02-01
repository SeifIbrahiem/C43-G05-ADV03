using System.Runtime.InteropServices;

namespace C43_G05_ADV03
{
    //store function in variable
    //class//interface//enum//struct
    //delegete //step 1 : create new data type (Delegate)
    //public delegate int StringfuncDelegate (string s);
    internal class Program
    {
        public static void printarray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] numbers = { 9, 8, 5, 6, 2, 3, 7 };
            printarray(numbers);
            //Sortingalgorithm.BubblesortAscending(numbers);
            //Sortingalgorithm.BubblesortSDscending(numbers);
            //printarray(numbers);
            sortingfunDelegate X = Sortingcondition.comparegtr;
            Sortingalgorithm.Bubblesort(numbers, X);
            printarray(numbers);
        }
    } 
}    

       
    


