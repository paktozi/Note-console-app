using System;

namespace FileReader.Models
{
    public static class Validator
    {
        public static bool IsValidInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        public static bool IsNotValidNumber(int number, int listCount)
        {
            if (number <= 0 || number > listCount)
            {
                Console.WriteLine($"{number} is not valid number!");
                return true;
            }
            return false;
        }
    }
}
