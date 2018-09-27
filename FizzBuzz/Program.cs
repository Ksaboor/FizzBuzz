using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Hello World!");
            FizzBuzzprinter(50);
        }

        private static void FizzBuzzprinter(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz" + " ");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz" + " ");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz" + " ");
                else
                    Console.WriteLine(i + " ");
                
            }
        }
    }
}