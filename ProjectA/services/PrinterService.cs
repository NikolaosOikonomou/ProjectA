using ProjectA.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.menu;

namespace ProjectA.services
{
    
    class PrinterService
    {

        public static void Printer(List<Student> students)
        {
            int i = 1;
            foreach (var student in students)
            {
                Console.WriteLine($"{i}. {student}");
                i += 1;
            }
        }

        public static void Printer(List<Trainer> trainers)
        {
            int i = 1;
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{ i}. {trainer}");
                i += 1;
            }
        }

        public static void Printer(List<Assignment> assignments)
        {
            int i = 1;
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{ i}. {assignment}");
                i += 1;
            }
        }

        public static void Printer(List<Course> courses)
        {
            int i = 1;
            foreach (var course in courses)
            {
                Console.WriteLine($"{i}. {course}");
                i += 1;
            }
        }
      
        public static void Printer1(List<Course> courses)
        {
            int j = 1;
            for (int i = 0; i < courses.Count; i++)
            {
                foreach (var student in courses[i].StudentsPerCourse)
                {
                    Console.WriteLine($"{j}. {student}");
                    j += 1;
                }
            }
        }

        public static void Printer2(List<Course> courses)
        {
            int j = 1;
            for (int i = 0; i < courses.Count; i++)
            {
                foreach (var trainer in courses[i].TrainersPerCourse)
                {
                    Console.WriteLine($"{j}. {trainer}");
                    j += 1;
                }
            }
        }

        public static void Printer3(List<Course> courses)
        {
            int j = 1;
            for (int i = 0; i < courses.Count; i++)
            { 
                foreach (var assignment in courses[i].AssignmentsPerCourse)
                {
                    Console.WriteLine($"{j}. {assignment}");
                    j += 1;
                }   
            }
        }

        public static void Printer4(List<Student> students)
        {
            int j = 1;
            for (int i = 0; i < students.Count; i++)
            {
                foreach (var assignment in students[i].AssignmentsPerStudent)
                {
                    Console.WriteLine($"{j}. {assignment}");
                    j += 1;
                }
            }
        }

        public static void Printer5(List<Course> courses)
        {
            int k = 1;
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses[i].StudentsPerCourse.Count; j++) 
                {
                    foreach (var assignment in courses[i].StudentsPerCourse[j].AssignmentsPerStudent) 
                    {
                        Console.WriteLine($"{k}. {assignment}");
                        k += 1;
                    }
                }
            }
        }

        public static void AssignmentsCurrentWeek(School school)
        {
            Console.WriteLine("\n\nGive a Date for the Assignments with this DD-MM-YY format");
            DateTime userDateInput;
            
            while (!DateTime.TryParse(Console.ReadLine(), out userDateInput))
            {
                Console.WriteLine("Wrong Format.Please give a Date with this DD-MM-YY format");
            }
            List<Student> test = DistributionPerCourseService.GetStudentsAssignementsPerWeek(school.Courses, userDateInput);
            Console.WriteLine("\n----------------------------------------------< STUDENTS WITH ASSIGNMENT THIS WEEK >------------------------------------------\n");
            if (test.Count == 0)
                Console.WriteLine("In this week no Student has any Assignments for submition.");
            else
            {
                int i = 1;
                foreach (var studnet in test)
                {
                    Console.WriteLine($"{i}. {studnet}");
                    i += 1;
                    //foreach (var assignment in studnet.AssignmentsPerStudent)
                    //{
                    //    Console.WriteLine(assignment);
                    //}
                }
            }
        }

        public static void ListPrinter(School school)
        {
            
            bool stop = true;
            do
            {
                int choice = MenuService.ChoiceForLists();
                while (choice < 0 || choice > 10 )
                {
                    Console.WriteLine("\nWrong input, Please try again");
                    choice =int.Parse(Console.ReadLine());
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("GOODBYEEEEEE!!");
                        stop = false;
                        break;
                    case 1:
                        Console.WriteLine("\n--------------------------------------------------------< STUDENTS >---------------------------------------------------");
                        Printer(school.Students);
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("\n---------------------------------------------------------< TRAINERS >----------------------------------------------------\n");
                        Printer(school.Trainers);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 3:
                        Console.WriteLine("\n--------------------------------------------------------< ASSIGNMENT >---------------------------------------------------\n");
                        Printer(school.Assignments);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 4:
                        Console.WriteLine("\n---------------------------------------------------------< COURSES >-----------------------------------------------------\n");
                        Printer(school.Courses);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 5:
                        Console.WriteLine("\n----------------------------------------------------< STUDENTS PER COURSE >----------------------------------------------\n");
                        Printer1(school.Courses);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 6:
                        Console.WriteLine("\n----------------------------------------------------< TRAINERS PER COURSE >----------------------------------------------\n");
                        Printer2(school.Courses);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 7:
                        Console.WriteLine("\n---------------------------------------------------< ASSIGNMENT PER COURSE >---------------------------------------------\n");
                        Printer3(school.Courses);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 8:
                        Console.WriteLine("\n-----------------------------------------------< ASSIGNMENT PER STUDENT PER COURSE >--------------------------------------\n");
                        Printer5(school.Courses);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 9:
                        Console.WriteLine("\n-----------------------------------------------< STUDENTS IN MORE THAN ONE COURSE>--------------------------------------------\n");
                        Printer(school.CommonStudents);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case 10:
                        AssignmentsCurrentWeek(school);
                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
                        break;
                }
            } while (stop);
        }

    }
}
