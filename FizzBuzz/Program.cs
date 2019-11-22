using System;

namespace cSharpFizzBuzz
{
    public class Program
    {
        static int fizzer = 3;
        static int buzzer = 5;
        static int fizzbuzzer = fizzer * buzzer;

        public string FizzBuzz(int n)
        {
            if (n % fizzbuzzer == 0)
            {
                return "FizzBuzz";
            }
            else if (n % fizzer == 0) 
            {
                return "Fizz";
            }  
            else if (n % buzzer == 0)
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
