using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handaon28._12._21
{
    class Program
    {
        // COUNT THE STRING
        /*static void Main(string[] args)
           {
               Console.WriteLine("Enter the sentence:");
               string str = Console.ReadLine();
               str = str.Replace(" ", string.Empty);

               while(str.Length>0)
               {
                   Console.Write(str[0] + " :");
                   int count = 0;
                   for(int i=0; i< str.Length; i++)
                   {
                       if(str[0] == str[i])
                       {
                           count++;
                       }
                   }
                   Console.WriteLine(count);
                   str = str.Replace(str[0].ToString(), string.Empty);
               }
               Console.ReadLine();
           }*/


        //REVERSE THE STRING

        /* static void Main(string[] args)
            {

             string str = " ",reverse =" ";
             Console.Write("Enter the string:");
             str = Console.ReadLine();

             for(int i = str.Length-1; i>=0; i--)
              {
                reverse += str[i];
              }
             Console.WriteLine("Reverse of string:" + reverse);
             Console.ReadKey();
            }*/

        // SUBSTRING

        /* static void subString(string str,int n)
          {
          for (int len = 1; len <= n;len++)
          {
             for (int i = 0;i <= n - len; i++)
             {
                 int j = i + len - 1;

                 for (int k = i; k <= j; k++)
                     Console.Write(str[k]);
                     Console.WriteLine();
             }
         }
     }
              static public void Main()
               {
                 string str = " ";
                 Console.Write("Enter the string:");
                 str = Console.ReadLine();
                 subString(str, str.Length);
                 Console.ReadLine();
             }*/


        //REVERSE THE SENTENCE

        /* static void reverse(String k)
         {
             Stack<String> s = new Stack<String>();
             String[] token = k.Split(' ');
             for (int i = 0; i < token.Length; i++)
             {
                 s.Push(token[i]);
             }

             while (s.Count != 0)
             {
                 Console.Write(s.Peek() + " ");
                 s.Pop();
             }
         }
          public static void Main(String[] args)
         {
             String k = " ";
             Console.WriteLine("Enter the sentence:" + k);
             k = Console.ReadLine();
             reverse(k);
             Console.ReadLine();
         }*/

        // second largest array
        
        /*static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element of array");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int length = arr.Length;
            Program program = new Program();
            program.SeconadLargestValue(arr, length);
        }

        private void SeconadLargestValue(int[] arr, int length)
        {
            int maxValue = 0;
            int secondMaxValue = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = arr[i];
                }
                else if (arr[i] > secondMaxValue)
                {
                    secondMaxValue = arr[i];
                }
            }
            Console.WriteLine("First Largest number :" + maxValue);
            Console.WriteLine("Second Largest number :" + secondMaxValue);
            Console.ReadLine();
        }*/
    }

}


