using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class Assignment
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private DateTime _subDateTime;

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }
        
        public Assignment()
        {

        }
        public Assignment(string title,string description,DateTime subDateTime)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;           
        }
        public override string ToString()
        {
            return ($"Assignment Title: {Title}, Description: {Description}, Submission Date: {SubDateTime}");
        }
    }
}
