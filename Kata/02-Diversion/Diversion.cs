﻿using System;
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
            List<string> binaryList = new List<string>();
            int count = 1 << number;

            for (int i = 0; i < count; i++)
            {
                binaryList.Add(Convert.ToString(i, 2).PadLeft(number, '0'));
            }

            return binaryList;
        }

        public int GetDiversion(List<string> binaryList)
        {
            return binaryList.Count;
        }
    }
}