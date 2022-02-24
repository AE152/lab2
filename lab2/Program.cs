using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            //Проверка операций
            RomanNumber test1 = new RomanNumber(9);
            Console.WriteLine("test1 = " + test1);
            RomanNumber test2 = new RomanNumber(3);
            Console.WriteLine("test2 = " + test2);

            RomanNumber add = RomanNumber.Add(test1, test2);
            Console.WriteLine("add = " + add);

            RomanNumber sub = RomanNumber.Sub(test1, test2);
            Console.WriteLine("sub = " + sub);

            RomanNumber mul = RomanNumber.Mul(test1, test2);
            Console.WriteLine("mul = " + mul);

            RomanNumber div = RomanNumber.Div(test1, test2);
            Console.WriteLine("div = " + div);

            string str = test1.ToString();
            Console.WriteLine("str = " + str);

            var clon = test1;
            clon = RomanNumber.Add(test1, test1);
            Console.WriteLine("clon = " + clon);
            Console.WriteLine("test1 = " + test1);

            RomanNumber[] digits = { test1, test2, add, sub, mul, div };
            Console.WriteLine("Массив до сортировки:");
            foreach (RomanNumber dig in digits)
            {
                Console.Write(dig.ToString() + " ");
            }
            Console.WriteLine();

            Array.Sort(digits);
            Console.WriteLine("Массив после сортировки:");
            foreach (RomanNumber dig in digits)
            {
                Console.Write(dig.ToString() + " ");
            }
            Console.WriteLine();

            //Проверка исключений
            try
            {
                RomanNumber n = new RomanNumber(0);
            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                RomanNumber.Sub(test2, test1);
            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                RomanNumber.Div(test2, test1);
            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}