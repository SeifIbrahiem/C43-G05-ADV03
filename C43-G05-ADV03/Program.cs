using System.Runtime.InteropServices;

namespace C43_G05_ADV03
{
    //store function in variable
    //class//interface//enum//struct
    //delegete //step 1 : create new data type (Delegate)
    //public delegate int StringfuncDelegate (string s);
    internal class Program
    {
        
        #region ex3
        //public static void printarray<T>(T[] values)
        //{
        //    Console.WriteLine();
        //    foreach (T item in values)
        //    {
        //        Console.Write($"{item}");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion


        static void Main()
        {
            #region ex3
            //int[] numbers = { 9, 8, 5, 6, 2, 3, 7 };
            //printarray(numbers);
            //Sortingalgorithm.BubblesortAscending(numbers);
            //Sortingalgorithm.BubblesortSDscending(numbers);
            //printarray(numbers);
            //sortingfunDelegate X = Sortingcondition.comparegtr;
            //Sortingalgorithm.Bubblesort(numbers, X);
            //printarray(numbers); 
            #endregion

            #region built in delegate
            //predicate // func //action
            // Predicate<int>predicate= Conditionesfunction.checkeven
            // bool r = Predicate.invoke(1);

            //func
            //Func<int> func = FunO1;

            //Action action = print;
            //action.Invoke();
            //or action();

            #endregion
            
        }
        //public static int FunO1() 
        //{
        //    return 1;
        //}
    } 
}    

       
    


