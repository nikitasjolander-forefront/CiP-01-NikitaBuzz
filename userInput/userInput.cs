using System;
using static CiP_FizzlyBizz.userInput.NumberValidation;


namespace CiP_FizzlyBizz.userInput
{
    public class UserInput
    {
        public static long GetUserInput()
        {
            Console.WriteLine($"Enter a number between {MinValue} and {MaxValue}:");
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine("\n");
                if (TryParseInRange(input, out var number))
                    return number;
                Console.WriteLine($"Invalid input. Please enter an integer between {MinValue} and {MaxValue}:");
            }
        }
    }
}
