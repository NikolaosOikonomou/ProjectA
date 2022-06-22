using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class ListsPerCourse: Course
    {
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }

    }
}
