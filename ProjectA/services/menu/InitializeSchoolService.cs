using ProjectA.domain;
using ProjectA.menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectA.services.menu
{
    static class InitializeSchoolService
    {
        public static List<Course> InitiateCourse(int choice)
        {
            //int numberOfEntries = MenuService.NumberOfEntries();
            int numberOfEntries = UserInputValidation.JsonInputForCourses(MenuService.NumberOfEntries());
            List<Course> courses = new List<Course>();
            switch (choice)
            {
                case 1:
                    courses = UserInputDataServive.GenerateCourses(numberOfEntries);

                    break;
                case 2:
                    string file =Path.GetFileName(@"C:\Users\Nikos\Desktop\ProjectA\ProjectA\CourseData.json");
                    JsonCourseDataService jsonCourseDataService = new JsonCourseDataService(file, numberOfEntries);
                    courses = jsonCourseDataService.Courses;
                    break;
                default:
                    break;
            }
            return courses;

        }

        public static List<Trainer> InitiateTrainer(int choice)
        {
            //int numberOfEntries = MenuService.NumberOfEntries();
            int numberOfEntries = UserInputValidation.JsonInputForTrainers(MenuService.NumberOfEntries());
            List<Trainer> trainers = new List<Trainer>();
            switch (choice)
            {
                case 1:
                    trainers = UserInputDataServive.GenerateTrainers(numberOfEntries);
                    break;
                case 2:
                    string file = Path.GetFileName(@"C:\Users\Nikos\Desktop\ProjectA\ProjectA\TrainerData.json");
                    JsonTrainerDataService jsonTrainerDataService = new JsonTrainerDataService(file, numberOfEntries);
                    trainers = jsonTrainerDataService.Trainers;
                    break;
                default:
                    break;
            }
            return trainers;
        }
        public static List<Student> InitiateStudent(int choice)
        {
            //int numberOfEntries = MenuService.NumberOfEntries();
            int numberOfEntries = UserInputValidation.JsonInputForStudents(MenuService.NumberOfEntries());
            List<Student> students = new List<Student>();
            switch (choice)
            {
                case 1:
                    students = UserInputDataServive.GenerateStudents(numberOfEntries);
                    break;
                case 2:
                    string file = Path.GetFileName(@"C:\Users\Nikos\Desktop\ProjectA\ProjectA\StudentData.json");
                    JsonStudentDataService jsonStudentDataService = new JsonStudentDataService(file, numberOfEntries);
                    students = jsonStudentDataService.Students;
                    break;
                default:
                    break;
            }
            return students;

        }
        public static List<Assignment> InitiateAssignment(int choice)
        {
            //int numberOfEntries = MenuService.NumberOfEntries();
            int numberOfEntries  = UserInputValidation.JsonInputForAssignments(MenuService.NumberOfEntries());
            List<Assignment> assignments = new List<Assignment>();
            switch (choice)
            {
                case 1:
                    assignments = UserInputDataServive.GenerateAssignments(numberOfEntries);
                    break;
                case 2:
                    string file = Path.GetFileName(@"C:\Users\Nikos\Desktop\ProjectA\ProjectA\AssignmentData.json");
                    JsonAssignmentDataService jsonAssignmentDataService = new JsonAssignmentDataService(file, numberOfEntries);
                    assignments = jsonAssignmentDataService.Assignments;
                    break;
                default:
                    break;
            }
            return assignments;

        }

        public static List<Course> FillCourses(List<Course> courses)
        {
            if (courses == null)
            {
                int choice = MenuService.TypeOrSynthetic();
                while (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Wrong input.PLease try again.");
                    choice = MenuService.TypeOrSynthetic();
                } 
                courses = InitiateCourse(choice);
               
                return courses;
            }
            else
            {
                Console.WriteLine("Courses are already registered for this semester, please chooce again:\n");
                return courses;
            }
        }

        public static List<Trainer> FillTrainers(List<Trainer> trainers)
        {
            if (trainers == null)
            {
                int choice = MenuService.TypeOrSynthetic();
                while (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Wrong input.PLease try again.");
                    choice = MenuService.TypeOrSynthetic();
                }
                trainers = InitiateTrainer(choice);
                return trainers;
            }
            else
            {
                Console.WriteLine("Trainers are already registered for this semester, please chooce again:\n");
                return trainers;
            }
        }

        public static List<Student> FillStudents(List<Student> students)
        {
            if (students == null)
            {
                int choice = MenuService.TypeOrSynthetic();
                while (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Wrong input.PLease try again.");
                    choice = MenuService.TypeOrSynthetic();
                }
                students = InitiateStudent(choice);
                return students;
            }
            else
            {
                Console.WriteLine("Students are already registered for this semester, please chooce again:\n");
                return students;
            }
        }

        public static List<Assignment> FillAssignment(List<Assignment> assignemnts)
        {
            if (assignemnts == null)
            {
                int choice = MenuService.TypeOrSynthetic();
                while (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Wrong input.PLease try again.");
                    choice = MenuService.TypeOrSynthetic();
                }
                assignemnts = InitiateAssignment(choice);
                return assignemnts;
            }
            else
            {
                Console.WriteLine("Assignments are already registered for this semester, please chooce again:\n");
                return assignemnts;
            }
        }

    }
}
