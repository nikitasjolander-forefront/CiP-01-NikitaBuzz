using CiP_FizzlyBizz.userInput;

namespace CiP_FizzlyBizz.logic
{
    public class FizzLogic
    {


        public static string FizzBizz(int n)
        {
            var fizzbuzz = "";
            fizzbuzz = (n % 3 == 0)? "Fizz": "";
            fizzbuzz = (n % 5 == 0)? fizzbuzz + "Buzz": fizzbuzz ;
            return String.IsNullOrEmpty(fizzbuzz)? n.ToString() : fizzbuzz ;

        }

        public static void ProcessFizzBuzz(long userNumber)
        {
            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(FizzBizz(i));
            }
        }
    }

}
