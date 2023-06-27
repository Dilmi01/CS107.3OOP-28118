using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t8q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter value:");
                num[i] = int.Parse(Console.ReadLine());
            }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("num[i]");
                }
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + num[i];
                }
            
            Console.ReadKey();
            
        }
    }
}
