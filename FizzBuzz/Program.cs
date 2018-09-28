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
            var str = "";
            for (var j = 1; j <= i; j++)
            {
                if (i % 3 == 0)  
                {  
                    str += "Fizz";  
                }  
                if (i % 5 == 0)  
                {  
                    str += "Buzz";  
                }  
                if (str.Length == 0)  
                {  
                    str = i.ToString();  
                }  
                Console.WriteLine(str); 
            }
        }
    }
}