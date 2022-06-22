using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class StudentAssignment:Assignment
    {
        Random rand = new Random((int)DateTime.Now.Ticks);
        private int _oralMark;
        public int OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        private int _totalMark;

        public int TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }
        private DateTime submittedOn;

        public DateTime SubmittedOn
        {
            get { return submittedOn; }
            set { submittedOn = value; }
        }

        public StudentAssignment()
        {

        }
        public StudentAssignment(string title, string description, DateTime subDateTime, int oralMark
            ) : base(title,description,subDateTime)
        {
            SubmittedOn = subDateTime.AddDays(rand.Next(3,20));
            OralMark = oralMark;
            TotalMark = oralMark + rand.Next(0,81);
        }

        public StudentAssignment(string title, string description, DateTime subDateTime, DateTime submittedOn,
            int oralMark, int totalMark) : base(title, description, subDateTime)
        {
            SubmittedOn = submittedOn;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public override string ToString()
        {
            return ($"Assignment Title: {Title}, Description: {Description}, Submission Date: {SubDateTime}, " +
                $"Submitted On: {SubmittedOn}, Oral Mark: {OralMark}/20, Total Mark {TotalMark}/100.");
        }
    }
}
