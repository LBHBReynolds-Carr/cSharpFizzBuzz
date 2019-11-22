using System;

namespace cSharpFizzBuzz
{
    public class Program
    {
        public string FizzBuzz(int n)
        {
            if (n % 3 == 0) 
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            } 
            else 
            {
                return n.ToString();
            }
        }
    }
}
