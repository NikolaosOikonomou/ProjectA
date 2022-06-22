using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.services;
using ProjectA.domain;


namespace ProjectA.menu
{
    static class MenuService
    {
        public static int Starting()
        {
            Console.WriteLine("\nHow do you want to proceed?\n");
            Console.WriteLine("[1] Add Course");
            Console.WriteLine("[2] Add Trainer");
            Console.WriteLine("[3] Add Student");
            Console.WriteLine("[4] Add Assigment");
            string input = Console.ReadLine();
            return UserInputValidation.LetterChecker(input);
        }

        public static int TypeOrSynthetic()
        {
            Console.WriteLine("Press [1] if want to type or [2] to use synthetic data");
            string input = Console.ReadLine();
            return UserInputValidation.LetterChecker(input);
        }

        public static int NumberOfEntries()
        {
            Console.WriteLine("How many entries do you want to make?");
            string input = Console.ReadLine();
            return UserInputValidation.LetterChecker(input);
        }

        public static int ChoiceForLists()
        {
            Console.WriteLine("[1] To print all the Students");
            Console.WriteLine("[2] To print all the Trainers");
            Console.WriteLine("[3] To print all the Assignments");
            Console.WriteLine("[4] To print all the Courses");
            Console.WriteLine("[5] To print Students Per Course");
            Console.WriteLine("[6] To print Trainers Per Course");
            Console.WriteLine("[7] To print Assignments Per Course");
            Console.WriteLine("[8] To print Assignments Per Student per Course");
            Console.WriteLine("[9] To print the Students who are in more than 1 Course");
            Console.WriteLine("[10] To print the Students who have to submit an Assignment a particular date");
            Console.WriteLine("[0] To Exit");

            string input = Console.ReadLine();
            return UserInputValidation.LetterChecker(input);

        }
    }
}
