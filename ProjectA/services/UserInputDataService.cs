using ProjectA.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.services
{
    static class UserInputDataServive
    {
        public static List<Student> GenerateStudents(int noOfStudent)
        {
            List<Student> studentList = new List<Student>();
            string name;
            string lName;
            double tuition;
            for (int i = 0; i < noOfStudent; i++)
            {
                Console.WriteLine("name of student");
                name = Console.ReadLine();
                while (!UserInputValidation.IsAllLetters(name))
                {
                    Console.WriteLine("First name MUST contain only letters");
                    name = Console.ReadLine();
                } 

                Console.WriteLine("last name of student");
                lName = Console.ReadLine();
                while (!UserInputValidation.IsAllLetters(lName))
                {
                    Console.WriteLine("Last name MUST contain only letters");
                    lName = Console.ReadLine();
                }

                Console.WriteLine("Birthday of student? Year-Month-Day:");
                string tempDate = Console.ReadLine();
                while (!UserInputValidation.CheckDate(tempDate))
                {
                    Console.WriteLine("Birthday was not in the correct format.Please try again  Year-Month-Day");
                    tempDate = Console.ReadLine();
                }
                DateTime dateOfBirth = Convert.ToDateTime(tempDate);
                Console.WriteLine("tuition of student");
                tuition = Convert.ToDouble(Console.ReadLine());
                while (tuition < 0)
                {
                    Console.WriteLine("Tuition can not be negative.Please try again");
                    tuition = Convert.ToDouble(Console.ReadLine());
                }

                studentList.Add(new Student(name, lName,dateOfBirth, tuition));
            }
            return studentList;

        }
        public static List<Trainer> GenerateTrainers(int noOfTrainers)
        {
            List<Trainer> trainerList = new List<Trainer>();
            string name;
            string lName;
            
            for (int i = 0; i < noOfTrainers; i++)
            {
                int subjectChoice;
                Console.WriteLine("name of Trainer");
                name = Console.ReadLine();
                while (!UserInputValidation.IsAllLetters(name))
                {
                    Console.WriteLine("First name MUST contain only letters");
                    name = Console.ReadLine();
                }
                Console.WriteLine("last name of Trainer");
                lName = Console.ReadLine();
                while (!UserInputValidation.IsAllLetters(lName))
                {
                    Console.WriteLine("Last name MUST contain only letters");
                    lName = Console.ReadLine();
                }
                Console.WriteLine("For subject of Trainer please Press: [1]Java, [2]C#, [3]JScript, [4]Python");
                bool temp = int.TryParse(Console.ReadLine(), out subjectChoice);
                while (temp == false)
                {
                    Console.WriteLine("Please give a valid choice");
                    temp = int.TryParse(Console.ReadLine(), out subjectChoice);
                }
                
                while (!UserInputValidation.CheckSubject(subjectChoice))
                {
                    Console.WriteLine("Please give a valid choice");
                    subjectChoice = int.Parse(Console.ReadLine());
                }
                string subject = UserInputValidation.ConvertedSubject(subjectChoice);
                trainerList.Add(new Trainer(name, lName, subject));
            }
            return trainerList;

        }

        public static List<Assignment> GenerateAssignments(int noOfAssignments)
        {
            List<Assignment> assignmentsList = new List<Assignment>();
            for (int i = 0; i < noOfAssignments; i++)
            {
                Console.WriteLine("tittle of Assignment");
                string title = Console.ReadLine();
                Console.WriteLine("description of Assignment");
                string description = Console.ReadLine();
                Console.WriteLine("When does the assignment should be submited? Year/Month/Day:");
                string tempDate = Console.ReadLine();
                while (!UserInputValidation.CheckDate(tempDate))
                {
                    Console.WriteLine("Submition date was not in the correct format.Please try again  Year-Month-Day");
                    tempDate = Console.ReadLine();
                }
                DateTime subdate = Convert.ToDateTime(tempDate);
                assignmentsList.Add(new Assignment(title, description, subdate));
            }
            return assignmentsList;

        }

        public static List<Course> GenerateCourses(int noOfCourses)
        {
            List<Course> coursesList = new List<Course>();
            for (int i = 0; i < noOfCourses; i++)
            {
                int subjectChoice, typeChoice;
                
                Console.WriteLine("tittle of the Course");
                string title = Console.ReadLine();
                Console.WriteLine("stream of the Course: [1]Java, [2]C#, [3]JScript, [4]Python");
                
                bool temp = int.TryParse(Console.ReadLine(),out subjectChoice);
                while (temp == false)
                {
                    Console.WriteLine("Please give a valid choice");
                    temp = int.TryParse(Console.ReadLine(), out subjectChoice);
                }
                while (!UserInputValidation.CheckSubject(subjectChoice))
                {
                    Console.WriteLine("Please give a valid choice");
                    subjectChoice = int.Parse(Console.ReadLine());
                }
                string stream = UserInputValidation.ConvertedSubject(subjectChoice);
                Console.WriteLine("Type of the Course: [1]Full Time, [2]Part Time");
                temp = int.TryParse(Console.ReadLine(), out typeChoice);
                while (temp == false)
                {
                    Console.WriteLine("Please give a valid choice");
                    temp = int.TryParse(Console.ReadLine(), out typeChoice);
                }
                
                while (!UserInputValidation.CheckType(typeChoice))
                {
                    Console.WriteLine("Please give a valid choice");
                    typeChoice = int.Parse(Console.ReadLine());
                }
                string type = UserInputValidation.ConvertedType(typeChoice);

                Console.WriteLine("Starting Date of the Course: Year/Month/Day:");
                string tempDate = Console.ReadLine();
                while (!UserInputValidation.CheckDate(tempDate))
                {
                    Console.WriteLine("Starting Date was not in the correct format.Please try again  Year-Month-Day");
                    tempDate = Console.ReadLine();
                }
                DateTime startingDate = Convert.ToDateTime(tempDate);

                Console.WriteLine("Ending Date of the Course: Year/Month/Day:");
                string tempDate1 = Console.ReadLine();
                while (!UserInputValidation.CheckDate(tempDate1))
                {
                    Console.WriteLine("Ending Date was not in the correct format.Please try again  Year-Month-Day");
                    tempDate1 = Console.ReadLine();
                }
                DateTime endingDate = Convert.ToDateTime(tempDate1);
                if(startingDate < endingDate)
                coursesList.Add(new Course(title, stream, type, startingDate, endingDate));
                else
                    coursesList.Add(new Course(title, stream, type, startingDate));
            }
            return coursesList;

        }
    }
}
