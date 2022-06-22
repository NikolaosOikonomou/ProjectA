using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.domain
{
    abstract class Human
    {
        private string  _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = FirstLetterUpper(value); }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = FirstLetterUpper(value); }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private string FirstLetterUpper(string input)
        {
            if (char.IsUpper(input, 0) == false)
            {
                input = char.ToUpper(input[0]) + input.Substring(1);
            }
            return input;
        }
    }
}
