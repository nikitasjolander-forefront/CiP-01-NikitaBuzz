using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiP_FizzlyBizz.userInput
{
    public static class NumberValidation
    {
        public const long MinValue = 1;
        public static long MaxValue = 1_000_000_000_000_000; // Changed from const to static

        public static bool TryParseInRange(string? input, out long value)
        {
            if (long.TryParse(input, out value) &&
                value >= MinValue &&
                value <= MaxValue)
            {
                return true;
            }

            value = 0;
            return false;
        }
    }
}