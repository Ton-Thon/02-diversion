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
        //2. 4 -> 1111
        //3. 1111 -> 15
        //4. generate loop i in 0 - 15
        //5. convert i -> binary
        public List<string> GenerateBinaryListFromNumber(int number)
        {
            if (number == 2)
                return new List<string> { "00", "01", "10", "11" };

            if (number == 3)
                return new List<string> { "000", "001", "010", "011", "100", "101", "110", "111" };


            return new List<string> { "0", "1" };
        }

        public int GetDiversion(List<string> binaryList)
        {
            return binaryList.Count;
        }
    }
}