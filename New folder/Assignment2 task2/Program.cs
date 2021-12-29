using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2_task2
{
    class person
    {
        String firstName;
        String lastName;
        int identify;
        public person(String firstName, String lastName, int identify)
        {
            
            this.identify = identify;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + "," + firstName + "identify" + identify);
        }
    }
    class Student : person
    {
        private int[] testScores;
        public Student(String firstName, String lastName, int identitify, int[] testScores)
            : base(firstName, lastName, identify)
        {
            this.testScores = testScores;
            this.firstName = firstName;
            this.lastName = lastName;
            this.identify = identify;
        }
        public char Calculate()
        {
            int sum = 0;
            float avg = 0;
            char grade = ' ';
            for (int i = 0, length = this.testScores.Length; i < testScores.Length; i++)
            {
                sum += this.testScores[i];
            }
            if (testScores.Length != 0)
                avg = sum / (float)this.testScores.Length;

            if (avg >= 90 && avg <= 100)
                grade = 'O';
            else if (avg >= 80 && avg < 90)
                grade = 'E';
            else if (avg >= 70 && avg < 80)
                grade = 'A';
            else if (avg >= 55 && avg < 70)
                grade = 'P';
            else if (avg >= 40 && avg < 55)
                grade = 'D';
            else if (avg < 40)
                grade = 'T';

            return grade;
        }
        class Program
        {
            public static void main()
            {
                Console.Write("Enter the firstName:");
                String firstName = Console.ReadLine();
                Console.Write("Enter the lastName:");
                String lastName = Console.ReadLine();
                Console.Write("Enter identify:");
                int identify = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of scores:");
                int numScores = int.Parse(Console.ReadLine());
                int[] testScores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    Console.Write("Enter test scores{0}:", (i + 1));
                    testScores[i] = int.Parse(Console.ReadLine());
                }
                Student s = new Student(firstName, lastName, identify, testScores);

                Console.WriteLine("grade:" + s.Calculate());
                Console.ReadLine();

            }
        }
    }
}


                        
    
        
