using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tt11q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1 :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2 :");
            double num2 = double.Parse(Console.ReadLine());

            calculation calobj = new calculation();
            calobj.setValues(num1, num2);

            Console.Write("Sum : " + calobj.getAdditon());
            Console.Write("Sub : " + calobj.getSubtraction());

            Console.Write("div : " + calobj.getDivision());
            Console.Write("mul : " + calobj.getMultiplication());


        }
    }
}
