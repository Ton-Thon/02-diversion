using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._02_Diversion
{
    public class Diversion
    {

        public int GetDiversion(int number)
        {
            return 0;
        }
        
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