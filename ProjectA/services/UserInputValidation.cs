using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.services
{

    /// <summary>
    /// Custom  Validations for user inputs
    /// </summary>
    class UserInputValidation
    {
        public bool CheckStringLength(string input)
        {
            return input.Length <= 3 ? false : true;
        }

        public bool CheckStringRange(string input, int minRange, int maxRange)
        {
            return (input.Length < minRange || input.Length > maxRange) ? false : true;
        }

        public static bool IsAllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public  string ValidName(string input, int minLength, string errorMessage)
        {
            while (CheckStringLength(input) == false)
            {
                Console.WriteLine($"{errorMessage} should have more than 2 characters, pls try again");
                input = Console.ReadLine();
            }
            if (char.IsUpper(input, 0) == false)
            {
                input = char.ToUpper(input[0]) + input.Substring(1);
            }
            return input;
        }

        public static bool CheckDate(string dateInput)
        {
            DateTime temp;
            return (DateTime.TryParse(dateInput, out temp)) ? true : false;
        }

        public static bool CheckSubject(int input)
        {
            return (input == 1 || input == 2 || input == 3 || input == 4) ? true : false;
        }

        public static int LetterChecker( string input)
        {
            int value;
            bool temp = int.TryParse(input, out value);
            while (!temp)
            {
                Console.WriteLine("Wrong input.Please try again.");
                temp = int.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }

        public static string ConvertedSubject(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Java";
                case 2:
                    return "C#";
                case 3:
                    return "JScript";
                case 4:
                    return "Python";
                default:
                    return null;
            }
        }

        public static bool CheckType(int input)
        {
            return (input == 1 || input == 2) ? true : false;
        }

        public static string ConvertedType(int choice)
        {
            if (choice == 1)
                return "Full Time";
            else
                return "Part Time";
        }

        public static int JsonInputForTrainers(int input)
        {
            while(input < 1 || input > 20)
            {
                Console.WriteLine("Input must be between 1 and 20");
                input = LetterChecker(Console.ReadLine());
            }
            return input;
        }

        public static int JsonInputForStudents(int input)
        {
            while (input < 1 || input > 40)
            {
                Console.WriteLine("Input must be between 1 and 40");
                input = LetterChecker(Console.ReadLine());
            }
            return input;
        }

        public static int JsonInputForCourses(int input)
        {
            while (input < 1 || input > 10)
            {
                Console.WriteLine("Input must be between 1 and 10");
                input = LetterChecker(Console.ReadLine());
            }
            return input;
        }

        public static int JsonInputForAssignments(int input)
        {
            while (input < 1 || input > 8)
            {
                Console.WriteLine("Input must be between 1 and 8");
                input = LetterChecker(Console.ReadLine());
            }
            return input;
        }
    }
}
