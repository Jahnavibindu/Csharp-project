using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_task2
{
    class person
    {
        String firstName;
        String lastName;
        int identifynumber;
        public person(String firstName, String lastName, int identify)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.identifynumber = identify;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + "," + firstName + "identify" + identifynumber);
        }
    }
}
