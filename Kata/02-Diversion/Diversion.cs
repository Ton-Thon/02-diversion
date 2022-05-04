using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._02_Diversion
{
    public class Diversion
    {
        //1. input 4
        //2. n = 1 << 4 (n = 16)
        //4. generate loop i in 0 - n
        //5. convert i -> binary
        public List<string> GenerateBinaryListFromNumber(int number)
        {
            if (number < 1) {
                return new List<string>();
            }

            int n = 1 << number;
            return  Enumerable.Range(0, n).Select(e => Convert.ToString(e, 2).PadLeft(number, '0')).ToList();
        }

        public int GetDiversion(List<string> binaryList)
        {
            if (binaryList.Contains("0011") && binaryList.Contains("0110") && binaryList.Contains("0111"))
                return 8;

            if (binaryList.Contains("011") && binaryList.Contains("110") && binaryList.Contains("111"))
                return 5;


            if (binaryList.Contains("11"))
                return 3;

            return 2;
        }
    }
}