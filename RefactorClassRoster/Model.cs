using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class Model
    {
        //data
        //get sets
        //constructor
        //objects

        private Instructor theInstructor;
        private List<Student> students; //normal list



        //constructor
        public Model()
        {
            theInstructor = new Instructor();
            students = new List<Student>();
        }

        //get instructor
        public Instructor getInstructor()
        {
            return theInstructor;
        }

        //set instructor
        public void setInstructor(string fname, string lname, string contact)
        {
            theInstructor.FirstName = fname;
            theInstructor.LastName = lname;
            theInstructor.ContactInfo = contact;
        }



        //add a student & makes a student object
        public void addStudent(string fname, string lname, string classRank)
        {
            students.Add(new Student(fname, lname, classRank));
        }

        //returns "as is" list
        public List<Student> getStudents()
        {
            return students;
        }

        //students sorted by last name
        public List<Student> sortByLN()
        {
            List<Student> allStudentsLN = students.OrderBy(s => s.LastName).ToList();
            return allStudentsLN;
        }

        //students sorted by class rank
        public List<Student> sortByCR()
        {
            //converts class rank to a string that can be sorted
            foreach (Student student in students)
            {
                if (student.ClassRank.ToLower().Equals("freshman"))
                {
                    student.ClassRank = "a";
                }
                else if (student.ClassRank.ToLower().Equals("sophomore"))
                {
                    student.ClassRank = "b";
                }
                else if (student.ClassRank.ToLower().Equals("junior"))
                {
                    student.ClassRank = "c";
                }
                else
                {
                    student.ClassRank = "d";
                }
            }

            //sorts class rank
            List<Student> allStudentsCR = students.OrderBy(s => s.ClassRank).ToList();

            //converts class rank back
            foreach (Student student in allStudentsCR)
            {
                if (student.ClassRank.ToLower().Equals("a"))
                {
                    student.ClassRank = "freshman";
                }
                else if (student.ClassRank.ToLower().Equals("b"))
                {
                    student.ClassRank = "sophomore";
                }
                else if (student.ClassRank.ToLower().Equals("c"))
                {
                    student.ClassRank = "junior";
                }
                else
                {
                    student.ClassRank = "senior";
                }
            }
            return allStudentsCR;

        }






    }
}
