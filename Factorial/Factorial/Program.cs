using System;

namespace Factorial
{
    public class Program
    {
        public static void Main()
        {
          Console.WriteLine(factorial(5));

        }
        public static int factorial(int num)
        {
                if(num == 0 || num == 1) // base condition
                {
                  return 1;
                }
                // Recursive case

                 return num * factorial(num-1);
        }
        
       
    }
}