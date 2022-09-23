using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClassRoster
{
    public class View
    {
        //no data
        //no controllers
        //no gets sets
        //methods for input/output



        public View()
        {
           
        }


        //get values from user
        public string getString()
        {
            string u = Console.ReadLine();
            return u;
        }
        
        public void printString(string theString)
        {
            Console.WriteLine(theString);
        }

        public int getNumber()
        {
            int x = 0;
            bool good = false;
            while (!good)
            {


                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    good = true;

                }
                catch
                {
                    Console.WriteLine("You didn't input a number.");

                }

            }
            return x;

        }
    }
}
