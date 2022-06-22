using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class Course
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _stream;

        public string Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private DateTime _startingDate;

        public DateTime StartingDate
        {
            get { return _startingDate; }
            set { _startingDate = value; }
        }
        private DateTime _endingDate;

        public DateTime EndingDate
        {
            get { return _endingDate; }
            set { _endingDate = value; }
        }

        public List<Student> StudentsPerCourse { get; set; }
        public List<Trainer> TrainersPerCourse { get; set; }
        public List<Assignment> AssignmentsPerCourse { get; set; }

        public Course()
        {

        }
        public Course(string title, string stream, string type, DateTime startingDate, DateTime endingDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartingDate = startingDate;
            EndingDate = endingDate;
            StudentsPerCourse = new List<Student>();
            TrainersPerCourse = new List<Trainer>();
            AssignmentsPerCourse = new List<Assignment>();
        }

        public Course(string title, string stream, string type, DateTime startingDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartingDate = startingDate;
            EndingDate = SetEndingDate(startingDate, type);
            StudentsPerCourse = new List<Student>();
            TrainersPerCourse = new List<Trainer>();
            AssignmentsPerCourse = new List<Assignment>();
        }

        public override string ToString()
        {
            return ($"Course Title {Title} stream: {Stream} type: {Type}" +
                $"starting: {StartingDate} and ending: {EndingDate}"); 
        }

        private DateTime SetEndingDate(DateTime date, string type)
        {
            if (type == "Full Time")
                return date.AddMonths(3);
            else
                return date.AddMonths(6);
        }
    }
}
