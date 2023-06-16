using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuto5q2.Properties;

namespace tuto5q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter km value:");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            double m = obj.kilometerTOmeter(km);

            Console.WriteLine(m.ToString());
            Console.ReadKey();
        }
    }
}
