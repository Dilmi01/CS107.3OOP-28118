using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7.q2.Properties
{
    internal class findmnmx
    {
        public void Method()
        {
            int min, max, i, avg;
            int[] Array = new int[10];
            Console.WriteLine("Enter elements in the array:");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("number"+i);
            }
            max = Array[0];
            min = Array[0];
            for (i = 1; i <= 10; i++)
            {
                if (Array[i] > max)
                {
                    Array[i] = max;
                }

                if (Array[i] < min)
                {
                    Array[i] = min;
                }
            }
            

        }
    }
}
