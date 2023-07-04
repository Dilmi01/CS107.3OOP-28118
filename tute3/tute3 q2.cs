using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tute3_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input1= ");
            string num1=Console.ReadLine();
            Console.WriteLine("Enter input2= ");
            string num2 = Console.ReadLine();
            
            double num1= double.Parse(num1);
            double num2 = double.Parse(num2);   

            Console.WriteLine(num1  "+" + num2   "=" + (num1+num2));
            Console.ReadLine();


        }
        
    }
}
