using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    if (i % j == 0)
                    {
                        if (j == 20)
                        {
                            Console.WriteLine(i);
                            Console.ReadLine();
                            return;
                        }
                    }
                    else break;
                }
            }
        }
    }
}
