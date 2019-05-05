using System;

namespace Recursive.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            double factorial = Factorial(number);

            Console.WriteLine(factorial.ToString());
        }

        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            //double factorial = 1;

            //for (int i = number; i >= number; i++)
            //{
            //    factorial = factorial * i;
            //}

            //return factorial;

            return number * Factorial(number - 1);
        }
    }
}
