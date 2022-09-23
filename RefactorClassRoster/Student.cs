using RefactorClassRoster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class Student : Person
    {
        //class rank private string
        private string classRank;

        public Student()
        {
            classRank = "";
        }

        //student constructor, inherits from Person
        public Student(string nfirstName, string nlastName, string nclassRank) : base(nfirstName, nlastName)
        {
            classRank = nclassRank;
        }

        //accessor & mutator
        public string ClassRank
        {
            get { return classRank; }
            set { classRank = value; }
        }

        //printed to string
        public override string ToString()
        {
            return $"Student:  {this.FirstName} {this.LastName}, {this.classRank}";

        }

    }
}