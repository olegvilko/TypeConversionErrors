
// tenThousandPi десять тысяч пи
// roundedTenThousandPi округленная десятка тысяч пи
// integerPartOfTenThousandPi целое число из десяти тысяч пи

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_conversion_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double tenThousand = 10000L;
            float tenThousandPi = (float)(pi * tenThousand);
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)(tenThousandPi);
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
            Console.ReadKey();
        }
    }
}
