using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_task2
{
    class Student : Person
    {
        private int[] testScores;
        public Student(String firstName, String lastName, int identify, int[] testScores)
           
        {
            this.testScores = testScores;
            this.firstName = firstName;
            this.lastName = lastName;
            this.identifyNumber = identify;
        }
        public char Calculate()
        {
            int sum = 0;
            float avg = 0;
            char grade = ' ';
            for (int i = 0; length = this.testScores.Length; i < length; i++)
            {
                sum += this.testScores[i];
            }
            if (testScores.Length != 0)
                avg = sum / (float)this.testScores.Length;

            if (avg >= 90 && avg <= 100)
            {
                grade = 'O';
            }
            else if (avg >= 80 && avg < 90)
            {
                grade = 'E';
            }
            else if (avg >= 70 && avg < 80)
            {
                grade = 'A';
            }
            else if (avg >= 55 && avg < 70)
            {
                grade = 'P';
            }
            else if (avg >= 40 && avg < 55)
            {
                grade = 'D';
            }
            else if (avg < 40)
            {
                grade = 'T';
            }

            return grade;

        }
    }
}



