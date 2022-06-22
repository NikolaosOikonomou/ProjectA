using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class School

    {
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> CommonStudents { get; set; }

        public School()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}    
