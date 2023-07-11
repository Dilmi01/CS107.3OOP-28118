using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tt11q1.Properties;

namespace tt11q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employeeID:");
            string empID = Console.ReadLine();

            Console.WriteLine("Enter employeeName:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter employee designation:");
            string empdesignation = Console.ReadLine();

            Employee empobj=new Employee();

            empobj.setempID(ID);
            empobj.setempName(name);
            empobj.setempDestination(designation);

            Console.WriteLine("Hello" + empobj.getempName() + "Your Employee Id is" + empobj.getempID() + "and your are a" + empobj.getempDestination());

        }
    }
}
