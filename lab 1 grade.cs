
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi!"+name);
            int mark = 50;
            if(mark >=75)
            {
                Console.WriteLine("Grade A");
            }else if(mark >=65 && mark<75)
            {
                Console.WriteLine("Grade B");
            }
            else if (mark >= 55 && mark < 65)
            {
                Console.WriteLine("Grade C");
            }
            else if (mark >= 45 && mark < 55)
            {
                Console.WriteLine("Grade C");
            }
            else if (mark >= 35 && mark < 45)
            {
                Console.WriteLine("Grade S");
            }
            else if ( mark < 35)
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}
