using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IsNumberPolindrom(909909);
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
