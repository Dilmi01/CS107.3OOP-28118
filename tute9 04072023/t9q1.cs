using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tute_9_q1.Properties;

namespace tute_9_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size  = Convert.ToInt32(Console.ReadLine());

            t9clz obj1= new t9clz();
            int[] array = obj1.arrayMethod(size);

            Console.WriteLine("\nDisplay the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "");            
            }
            Console.ReadLine();
        }
    }
}
