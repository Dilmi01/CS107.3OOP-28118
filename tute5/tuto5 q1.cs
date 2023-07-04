using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorials5.Properties;

namespace tutorials5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter km value");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            obj.kilometerTOmeter(km);


            Console.ReadLine();
        }
    }
}
