using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingApp
{
    class DoctorFile
    {
        public void CreateDoctor()
        {
            
            FileStream fsobj = new FileStream("D:\\Desktop\\capgemini Training\\Doctor Details", FileMode.Open, FileAccess.Read);
            StreamWriter sw = new StreamWriter(fsobj);
            Console.Write("Enter the DoctorName:");
            String DoctorName = Console.ReadLine();
            Console.Write("Enter the Profession:");
            String Profession = Console.ReadLine();
            Console.Write("Enter the Phone:");
            int Phone =Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the Address:");
            String Address  = Console.ReadLine();

            sw.WriteLine("DoctorName:" + DoctorName);
            sw.WriteLine("Profession:" + Profession);
            sw.WriteLine("Phone:" + Phone);
            sw.WriteLine("Address:" + Address);
            sw.Close();
            fsobj.Close();

        }
        static void Main(String[] arg)
        {
            DoctorFile doctorFileObj = new DoctorFile();
            doctorFileObj.CreateDoctor();
            Console.ReadKey();
        }
    }
}
