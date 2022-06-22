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
    class JsonStudentDataService : School
    {
        public JsonStudentDataService(string file, int numberOfEntries)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string json = reader.ReadToEnd();
                School dataInput = JsonConvert.DeserializeObject<School>(json);
                List<Student> students = new List<Student>();
                for (int i = 0; i < numberOfEntries; i++)
                {                 
                    Student student = new Student(dataInput.Students[i].FirstName, dataInput.Students[i].LastName, 
                        dataInput.Students[i].DateOfBirth, dataInput.Students[i].TuitionFees);
                    students.Add(student);
                }
                Students = students;
            }
        }
    }
}
