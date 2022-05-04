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
            return Enumerable.Range(0, n).Select(e => Convert.ToString(e, 2).PadLeft(number, '0')).ToList();
        }

        public int GetDiversion(List<string> binaryList)
        {
            int count = binaryList.Count;
            foreach (var binary in binaryList) {
                for (int i = 0; i < binary.Length - 1; i++)
                {
                    if(binary[i] == '1' && binary[i] == binary[i + 1])
                    {
                        count -= 1;
                        break;
                    }
                }
            }

            return count;
        }
    }
}