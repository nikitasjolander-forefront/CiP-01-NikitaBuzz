using CiP_FizzlyBizz.logic;
using CiP_FizzlyBizz.userInput;
using System;

namespace CiP_FizzlyBizz
{
    class Program
    {
        static void Main()
        {
            countOrPrintUserOption menu = new countOrPrintUserOption();
            menu.ShowMenu();
            Console.WriteLine("Try again? (y/n)");
            var input = Console.ReadLine();
            if (input != null && input.ToLower() == "y")
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
            /*long userNumber = UserInput.GetUserInput();
            var counts = Counter.CountFizzBuzz(userNumber);*/

            /*            Console.WriteLine($"From 1 to {userNumber}:");
                        Console.WriteLine($"Fizz: {counts.Fizz}");
                        Console.WriteLine($"Bizz: {counts.Bizz}");
                        Console.WriteLine($"FizzBuzz: {counts.FizzBuzz}");
                        Console.WriteLine($"Regular numbers: {counts.Regular}");*/
        }
    }
}