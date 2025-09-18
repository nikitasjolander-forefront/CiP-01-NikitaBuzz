using CiP_FizzlyBizz.logic;

namespace CiP_FizzlyBizz.userInput
{
    public class countOrPrintUserOption
    {
        public void DisplayOptions() =>
        Console.WriteLine("Choose an option:");
        public void ShowMenu()
        {
            Console.WriteLine("1. Print FizzBuzz sequence");
            Console.WriteLine("2. Count Fizz, Bizz, FizzBuzz, and Regular numbers");
            Console.Write("Enter your choice (1 or 2): ");
            var choice = Console.ReadLine();
            if (choice == "1") 
            {
                NumberValidation.MaxValue = 1000;
                var userNumber = UserInput.GetUserInput();
                FizzLogic.ProcessFizzBuzz(userNumber);
            }
            else if (choice == "2") {
                NumberValidation.MaxValue = 1_000_000_000_000_000;
                var userNumber = UserInput.GetUserInput();
                var (Fizz, Bizz, FizzBuzz, Regular) = Counter.CountFizzBuzz(userNumber);
                Console.WriteLine($"Fizz: {Fizz}, Bizz: {Bizz}, FizzBuzz: {FizzBuzz}, Regular: {Regular}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
    }
}
