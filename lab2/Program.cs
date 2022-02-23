using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            RomanNumber test = new RomanNumber(9);
            RomanNumber test2 = new RomanNumber(3);
            RomanNumber.Add(test,test2);
            RomanNumber.Sub(test, test2);
            RomanNumber.Div(test, test2);
            Console.WriteLine(test.ToString());

        }
    }
}