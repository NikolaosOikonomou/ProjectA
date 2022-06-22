using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.domain;
using ProjectA.menu;
using ProjectA.services.menu;

namespace ProjectA.services
{
    class Semester
    {
        public School Start()
        {
            Console.WriteLine("Wellcome to our School!");
            School school = new School();
            do
            {
                int choice = MenuService.Starting();
                while (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Wrong Input, Please try again.");
                    choice = MenuService.Starting();
                }
                switch (choice)
                {
                    case 1:
                        school.Courses= InitializeSchoolService.FillCourses(school.Courses);
                        break;
                    case 2:
                        school.Trainers = InitializeSchoolService.FillTrainers(school.Trainers);
                        break;
                    case 3:
                        school.Students = InitializeSchoolService.FillStudents(school.Students);
                        break;
                    case 4:
                        school.Assignments = InitializeSchoolService.FillAssignment(school.Assignments);
                        break;
                    default:
                        break;
                    }
            } while (school.Students == null || school.Courses == null || school.Assignments==null || school.Trainers == null);
            Console.WriteLine("\n\nCongratulations!The School is now ready!\nPress:\n");
            return DistributionPerCourseService.Start(school);
        }
    }
}
