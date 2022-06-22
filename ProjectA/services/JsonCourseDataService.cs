using Newtonsoft.Json;
using ProjectA.domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.services
{
    class JsonCourseDataService:School
    {
        public JsonCourseDataService(string file, int numberOfEntries)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string json = reader.ReadToEnd();
                School dataInput = JsonConvert.DeserializeObject<School>(json);
                List<Course> courses = new List<Course>();
                for (int i = 0; i < numberOfEntries; i++)
                {
                    Course course = new Course(dataInput.Courses[i].Title, dataInput.Courses[i].Stream, dataInput.Courses[i].Stream,
                    dataInput.Courses[i].StartingDate, dataInput.Courses[i].EndingDate);
                    courses.Add(course);
                }
                Courses = courses;
            }
        }
    }
}
