using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            RomanNumber test = new RomanNumber(9);        
            RomanNumber test2 = new RomanNumber(5);
            RomanNumber test3 = new RomanNumber(7);
            /*RomanNumber[] digits = { test, test2, test3};
            Array.Sort(digits);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(digits[i]);
            }*/
            //var clon = (RomanNumber)test.Clone();
            /*clon = RomanNumber.Add(test, clon);
            Console.WriteLine(test.ToString());
            Console.WriteLine(clon.ToString());*/
            /* RomanNumber test2 = new RomanNumber(3);
             RomanNumber.Add(test,test2);
             RomanNumber.Sub(test, test2);
             RomanNumber.Div(test, test2);
             Console.WriteLine(test.ToString());*/

        }
    }
}