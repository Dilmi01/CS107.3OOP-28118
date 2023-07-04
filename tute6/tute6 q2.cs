using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute08q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius value:");
            double r = double.Parse(Console.ReadLine());

          
            FindValues objFindValues = new FindValues();
            double A = objFindValues.findArea(r);

            Console.WriteLine("Area = " + A);

            
            double C = objFindValues.findCircumference(r);
            Console.WriteLine("Circumference = " + C);
            Console.ReadLine();
        }
    }
}
