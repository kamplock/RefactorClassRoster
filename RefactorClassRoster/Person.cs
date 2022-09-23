using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class Person
    {
        private string firstName;
        private string lastName;

        //default constructor
        public Person()
        {
            firstName = "";
            lastName = "";
        }

        //constructor for Person obj
        public Person(string nfirstName, string nlastName)
        {
            firstName = nfirstName;
            lastName = nlastName;

        }

        //accessors & mutators for first and last name
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }

    }
}