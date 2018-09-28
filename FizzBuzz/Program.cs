using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello World!");
            FizzBuzzprinter(100);
        }

        public static void FizzBuzzprinter(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz"); 
                }
                else if (j % 3 == 0 && j % 5 != 0)
                {
                 
                    Console.WriteLine("Fizz");
                } else if (j % 3 != 0 && j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}