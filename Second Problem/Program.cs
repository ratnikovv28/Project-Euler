using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Problem
{
    class Program
    {
        static void Main(string[] args)
        { 
            int first = 1;
            int second = 2;
            int temp = 0;
            int evenNum = 0;
            while (second < 4000000)
            {
                temp = second;
                if (second % 2 == 0) evenNum += second;
                second = first + second;
                first = temp;
            }

            Console.WriteLine(evenNum);
            Console.ReadLine();
        }
    }
}
