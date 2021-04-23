using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = 0;
            long secondNum = 0;
            for (int i = 1; i < 101; i++)
            {
                firstNum += i * i;
                secondNum += i;
            }

            secondNum = secondNum * secondNum;
            Console.WriteLine(secondNum - firstNum);
            Console.ReadLine();
        }
    }
}
