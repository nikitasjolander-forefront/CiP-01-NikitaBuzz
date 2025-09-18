using System;

namespace CiP_FizzlyBizz.logic
{
    public class Counter
    {
        public static (long Fizz, long Bizz, long FizzBuzz, long Regular) CountFizzBuzz(long n)
        {
            
            long countDivisibleBy3 = n / 3;
            long countDivisibleBy5 = n / 5;
            long countDivisibleBy15 = n / 15;
            
            
            long fizzCount = countDivisibleBy3 - countDivisibleBy15;
            long buzzCount = countDivisibleBy5 - countDivisibleBy15;
            long fizzBuzzCount = countDivisibleBy15;
            long regularCount = n - (fizzCount + buzzCount + fizzBuzzCount);
            
            return (fizzCount, buzzCount, fizzBuzzCount, regularCount);
        }
    }
}
