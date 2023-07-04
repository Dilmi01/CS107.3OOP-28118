using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute08q2
{
    internal class FindValues
    {
        public double findArea(double r)
        {
           //Console.WriteLine("Enter the radius value:");
            //double r = double.Parse(Console.ReadLine());

            double A = 3.142 * r * r;
            return A;
        }

        public double findCircumference(double r) 
        {
           // Console.WriteLine("Enter the radius value:");
            //double r = double.Parse(Console.ReadLine());
            double C = 2 * 3.142 * r;
            return C;   
        }
    }
}
