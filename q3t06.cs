using q3t6.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine("Enter your choice:");
            Console.ReadKey();

            string input = Console.ReadLine();

            Console.WriteLine("\n Enter number 1 :") ;
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            CalculateValues obj= new CalculateValues();

            double answer = 0;

            if (input == "1")
            {
                answer = obj.sum(num1,num2);
            }
            else if (input == "2")
            {
                answer = obj.sum(num1, num2);

            }
            else if (input == "3")
            {
                answer = obj.sum(num1, num2);
            }
            else if (input == "4")
            {
                answer = obj.sum(num1, num2);
            }
            Console.WriteLine("Answer is: " + answer);

        }
    }
}
