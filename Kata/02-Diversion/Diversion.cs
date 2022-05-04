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
        //2. 2 pow 4 -> 16
        //4. generate loop i in 0 - 16
        //5. convert i -> binary
        public List<string> GenerateBinaryListFromNumber(int number)
        {
            

            return new List<string> { "0", "1" };
        }

        public int GetDiversion(List<string> binaryList)
        {
            return binaryList.Count;
        }
    }
}