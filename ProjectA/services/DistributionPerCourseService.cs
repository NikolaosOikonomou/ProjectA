using ProjectA.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjectA.services
{
    class DistributionPerCourseService
    {
        public static School Start(School school)
        {
            DistributeStudents(school);
            DistributeTrainers(school);
            DistributeAssignments(school);
            FindCommonStudents(school);
            DistributeAssignementsPerStudent(school);
            return school;
        }

        public static void DistributeStudents(School school)
        {
            Random rand = new Random();
            for (int i = 0; i < school.Courses.Count; i++)
            {
                for (int j = 0; j < school.Students.Count / 2; j++)
                {
                    Student currentStudent = school.Students[rand.Next(0, (school.Students.Count))];
                    while (school.Courses[i].StudentsPerCourse.Contains(currentStudent))
                    {
                        currentStudent = school.Students[rand.Next(0, (school.Students.Count))];
                    }
                    school.Courses[i].StudentsPerCourse.Add(currentStudent);
                }
            }
        }

        public static void DistributeTrainers(School school)
        {
            int noOfTrainers = school.Trainers.Count;
            for (int i = 0; i < school.Courses.Count; i++)
            {
                for (int j = 0; j < noOfTrainers; j++)
                {
                    if (school.Courses[i].Stream.Contains(school.Trainers[j].Subject))
                    {
                        school.Courses[i].TrainersPerCourse.Add(school.Trainers[j]);
                    }
                }
            }
        }

        public static void DistributeAssignments(School school)
        {
            for (int i = 0; i < school.Courses.Count; i++)
            {
                for (int j = 0; j < school.Assignments.Count; j++)
                {
                    school.Courses[i].AssignmentsPerCourse.Add(school.Assignments[j]);
                }
            }
        }

        public static void FindCommonStudents(School school)
        {
            var counter = 0;
            List<Student> commonStudents = new List<Student>();
            for (int i = 0; i < school.Students.Count; i++)
            {
                counter = 0;
                for (int j = 0; j < school.Courses.Count; j++)
                {
                        if (school.Courses[j].StudentsPerCourse.Contains(school.Students[i]))
                        {
                            counter++;
                        }
                }
                if (counter > 1)
                {
                    commonStudents.Add(school.Students[i]);
                }
            }
            school.CommonStudents = commonStudents;
        }

        public static void DistributeAssignementsPerStudent(School school)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            List<StudentAssignment> tempList = new List<StudentAssignment>();
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < school.Courses.Count)
            {
                j = 0;
                while (j < school.Courses[i].StudentsPerCourse.Count)
                {
                    tempList.Clear();
                    k = 0;
                    while (k < school.Courses[i].AssignmentsPerCourse.Count)
                    {
                        StudentAssignment temp = new StudentAssignment(school.Courses[i].AssignmentsPerCourse[k].Title,
                          school.Courses[i].AssignmentsPerCourse[k].Description, school.Courses[i].AssignmentsPerCourse[k].SubDateTime, rand.Next(0, 21));
                        tempList.Add(temp);
                        k = k + 1;
                    }
                    school.Courses[i].StudentsPerCourse[j].AssignmentsPerStudent = tempList;
                    j = j + 1;
                }
                i = i + 1;
            }
        }

        public static List<DateTime> FindCalendarWeek(DateTime date)
        {
            List<DateTime> week = new List<DateTime>();
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    for (int i = 0; i < 5; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Tuesday:
                    week.Add(date.AddDays(-1));
                    for (int i = 0; i < 4; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Wednesday:
                    week.Add(date.AddDays(-2));
                    week.Add(date.AddDays(-1));
                    for (int i = 0; i < 3; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Thursday:
                    week.Add(date.AddDays(-3));
                    week.Add(date.AddDays(-2));
                    week.Add(date.AddDays(-1));
                    for (int i = 0; i < 2; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Friday:
                    for (int i = -4; i < 1; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Saturday:
                    for (int i = -5; i < 0; i++)
                        week.Add(date.AddDays(i));
                    break;
                case DayOfWeek.Sunday:
                    for (int i = -6; i < -1; i++)
                        week.Add(date.AddDays(i));
                    break;

            }
            return week;
        }

        public static List<Student> GetStudentsAssignementsPerWeek(List<Course> courses, DateTime date)
        {

            List<Student> studentsAssignmentInCurrentWeek = new List<Student>();
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses[i].StudentsPerCourse.Count; j++)
                {
                    foreach (var assignment in courses[i].StudentsPerCourse[j].AssignmentsPerStudent)
                    {
                        if (FindCalendarWeek(date).SequenceEqual(FindCalendarWeek(assignment.SubDateTime)))
                        {
                            if(!studentsAssignmentInCurrentWeek.Contains( courses[i].StudentsPerCourse[j]))
                            studentsAssignmentInCurrentWeek.Add(courses[i].StudentsPerCourse[j]);
                        }
                    }
                }
            }
            return studentsAssignmentInCurrentWeek;
        }
    }
}
