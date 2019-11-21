using System;

namespace cSharpFizzBuzz
{
    public class Program
    {
        public object FizzBuzz(int n)
        {
            if (n % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return n;    
            }
        }
    }
}
