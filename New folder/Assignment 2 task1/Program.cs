using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails JahnaviStudentDetails = new StudentDetails(1, "Jahnavi", "C#");
            StudentDetails BinduStudentDetails = new StudentDetails(2, "Bindu", "ASP.NET");
            JahnaviStudentDetails.payment(500);
            BinduStudentDetails.payment(1000);
            JahnaviStudentDetails.Print();
            Console.WriteLine(" ");
            BinduStudentDetails.Print();
        }
    }
    class StudentDetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoin { get; set; }
        public int FeePaidSoFar { get; set; }
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }
        public int TotalFee
        {
            get
            {
                if(CourseJoin.ToLower () == "CSharp")
                    return 2000;
                else if(CourseJoin.ToLower () == "ASP.NET")
                    return 3000;
                return 0;
            }
        }
        public StudentDetails(int rollno, string name, string CourseJoin)
        {
            RollNo = rollno;
            Name = name;
            CourseJoin = CourseJoin;
        }
        public void payment(int amount)
        {
            FeePaidSoFar += amount;
        }
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Join: {CourseJoin}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}
