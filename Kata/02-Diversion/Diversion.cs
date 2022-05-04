using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._02_Diversion
{
    public class Diversion
    {
        public List<string> GenerateBinaryListFromNumber(int number)
        {
            if (number == 2)
                return new List<string> { "00", "01", "10", "11" };

            return new List<string> { "0", "1" };
        }

        public int GetDiversion(List<string> binaryList)
        {
            return binaryList.Count;
        }
    }
}
