using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    class Trainer:Human
    {
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public Trainer()
        {

        }
        public Trainer(string fName,string lName,string subject)
        {
            FirstName = fName;
            LastName = lName;
            Subject = subject;
        }

        public override string ToString()
        {
            return ($"Trainer {FirstName} {LastName} with subject: {Subject}");
        }

    }
}
