using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class Student:Human
    {
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        private double _tuitionFees;

        public double TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }
        public List<StudentAssignment> AssignmentsPerStudent { get; set; }

        public Student()
        {

        }
        public Student(string fName,string lName,DateTime dateOfBirth,double tuitionFees)
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
            AssignmentsPerStudent = new List<StudentAssignment>();
        }

        public override string ToString()
        {
            return ($"Student {FirstName} {LastName} date of birth: {DateOfBirth} tuition fees: {TuitionFees}");
        }
    }
}
