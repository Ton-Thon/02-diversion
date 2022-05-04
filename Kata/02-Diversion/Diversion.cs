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
            return number > 0
                ? Enumerable.Range(0, 1 << number).Select(e => Convert.ToString(e, 2).PadLeft(number, '0')).ToList()
                : new List<string>();
        }

        public int CountBitOneAdjacent(List<string> binaryList)
        {
            return binaryList.Count(e => !e.Contains("11"));
        }
    }
}