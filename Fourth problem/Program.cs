using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимально возможное 998009
            int result = 0;
            int max = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    result = i * j;
                    if (result > max && IsNumberPolindrom(result))
                    {
                        max = result;
                    }
                }
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }

        public static bool IsNumberPolindrom(int number)
        {
            string strNumber = number.ToString();
            double lenght = Math.Ceiling((double)strNumber.Length / 2);
            for (int i = 0; i < lenght; i++)
            {
                if (!(strNumber[i] == strNumber[strNumber.Length - 1 - i])) return false;
            }

            return true;
        }
    }
}
