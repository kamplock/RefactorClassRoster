using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class Controller
    {
        public Controller()
        { 
            //where we "patch up the methods from other classes"
            View theView = new View();
            Model theModel = new Model();

            //get instructors info
            theView.printString("Enter the instructor's first name.");
            string fname = theView.getString();

            //checking fname
            while (string.IsNullOrEmpty(fname))
            {
                theView.printString("First name can't be empty. Try again!");
                fname = theView.getString();
            }

            //enter last name
            theView.printString("Enter the instructor's last name.");
            string lname = theView.getString();

            //check last name
            while (string.IsNullOrEmpty(lname))
            {
                theView.printString("Last name can't be empty. Try again!");
                lname = theView.getString();
            }

            //email
            theView.printString("Enter the instructor's email address.");
            string contact = theView.getString();

            //check email
            while (string.IsNullOrEmpty(contact))
            {
                theView.printString("Email address can't be empty. Try again!");
                contact = theView.getString();
            }

            //makes sure it's an email address. most emails contain "@"
            while (!contact.Contains("@"))
            {
                theView.printString("Not a valid email address. Try again!");
                contact = theView.getString();

            }


            //set the values
            theModel.setInstructor(fname, lname, contact);

            //start loop
            bool endLoop = false;
            while (!endLoop)
            {
                theView.printString("--------------------------------");
                theView.printString("What would you like to do?");
                theView.printString("1- add student\n" +
                    "2- view students\n" +
                    "3- view students sorted by last name\n" +
                    "4- view students sorted by rank\n" +
                    "5- quit");

                //the choice
                int choice = theView.getNumber();

                switch (choice)
                {
                    case 1:
                        //add student
                        theView.printString("Enter the student's first name.");
                        string sFname = theView.getString();

                        while (string.IsNullOrEmpty(sFname))
                        {
                            theView.printString("First name can't be empty. Try again!");
                            sFname = theView.getString();
                        }

                        //enter last name
                        theView.printString("Enter the student's last name");
                        string sLname = theView.getString();

                        //checks to make sure user put in a last name
                        while (string.IsNullOrEmpty(sLname))
                        {
                            theView.printString("Last name can't be empty. Try again!");
                            sLname = theView.getString();
                        }

                        //enter class rank
                        theView.printString("Enter the student's class rank (freshman, sophomore, junior, senior)");
                        string sClassRank = theView.getString();

                        //checks to make sure user put in a class rank
                        while (string.IsNullOrEmpty(sClassRank))
                        {
                            theView.printString("Class Rank can't be empty. Try again!");
                            sClassRank = theView.getString();
                        }

                        //loop to check valid class rank
                        while (true)
                        {

                            //checks to make sure user put in one of the valid options
                            if (sClassRank.ToLower().Equals("freshman"))
                            {
                                //adds student to the list
                                theModel.addStudent(sFname, sLname, sClassRank);
                                break;
                            }
                            else if (sClassRank.ToLower().Equals("sophomore"))
                            {
                                //adds student to the list
                                theModel.addStudent(sFname, sLname, sClassRank);
                                break;

                            }
                            else if (sClassRank.ToLower().Equals("junior"))
                            {
                                //adds student to the list
                                theModel.addStudent(sFname, sLname, sClassRank);
                                break;

                            }
                            else if (sClassRank.ToLower().Equals("senior"))
                            {
                                //adds student to the list
                                theModel.addStudent(sFname, sLname, sClassRank);
                                break;

                            }
                            else
                            {
                                //incorrect class rank
                                theView.printString("Invalid class rank. You must choose freshman, sophomore, junior, or senior.");
                                sClassRank = theView.getString();
                            }
                        }
                        break;
                    case 2:
                        //prints out instructor and students as is
                        theView.printString(theModel.getInstructor().ToString());
                        foreach(Student student in theModel.getStudents())
                        {
                            theView.printString(student.ToString());
                        }
                        break;
                    case 3:
                        //sorted by LN
                        theView.printString(theModel.getInstructor().ToString());
                        foreach (Student student in theModel.sortByLN())
                        {
                            theView.printString(student.ToString());
                        }
                        break;
                    case 4:
                        //sorted by CR
                        theView.printString(theModel.getInstructor().ToString());
                        foreach (Student student in theModel.sortByCR())
                        {
                            theView.printString(student.ToString());
                        }
                        break;
                    case 5:
                        theView.printString("Stopping the program...");
                        endLoop = true;
                        break;
                    default:
                        theView.printString("Please type a number 1-5");
                        break;

                }
            }

            
        }
    }
}
