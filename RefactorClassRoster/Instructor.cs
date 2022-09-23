using RefactorClassRoster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class Instructor : Person
    {
        //contact private string
        private string contact;

        public Instructor()
        {
            contact = "";
        }

        //instructor constructor, inherits from Person
        public Instructor(string nfirstName, string nlastName, string ncontact) : base(nfirstName, nlastName)
        {
            contact = ncontact;
        }

        //accessor & mutator
        public string ContactInfo
        {
            get { return contact; }
            set { contact = value; }
        }

        public override string ToString()
        {
            return $"Instructor:  {this.FirstName} {this.LastName}, {this.ContactInfo}";
        }

    }
}