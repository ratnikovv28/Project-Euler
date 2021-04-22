using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            uint del = 2;
            uint max = 0;
            long number = long.Parse(Console.ReadLine());
            while (number != 1)
            {
                if (number % del == 0)
                {
                    max = del;
                    number /= del;
                }
                del++;
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
