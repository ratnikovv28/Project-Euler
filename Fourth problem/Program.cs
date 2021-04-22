using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимально возможное 998001
            bool flag = false;
            int result = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    result = i * j;
                    if (IsNumberPolindrom(result))
                    {
                        Console.WriteLine(result);
                        Console.ReadLine();
                        return;
                    }
                }
            }
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
