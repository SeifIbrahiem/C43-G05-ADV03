namespace C43_G05_ADV03
{
    //store function in variable
    //class//interface//enum//struct
    //delegete //step 1 : create new data type (Delegate)
    public delegate int StringfuncDelegate (string s);
    internal class Program
    {
        static void Main()
        {
            //step 2 use delegate 
            StringfuncDelegate X;
            X = Stringfunction.Getcountofupperchars;
            int count = X.Invoke("Hello World"); 
            Console.WriteLine(count);
        }
    }
}
