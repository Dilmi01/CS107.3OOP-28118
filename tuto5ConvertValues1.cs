using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace tutorials5.Properties
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            double km = double.Parse(Console.ReadLine());
            double m = km * 1000;
            Console.WriteLine(m.ToString() + "m");


        }
    }
}
