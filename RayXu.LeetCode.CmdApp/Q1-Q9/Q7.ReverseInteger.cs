using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    //Given a 32-bit signed integer, reverse digits of an integer.

    //Example 1:
    //Input: 123
    //Output: 321

    //Example 2:
    //Input: -123
    //Output: -321

    //Example 3:
    //Input: 120
    //Output: 21
    partial class LeetCode
    {
        public int ReverseInteger(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = result * 10 + x % 10;
                x = x / 10;
            }

            if (result >= int.MaxValue || result <= int.MinValue)
            {
                return 0;
            }
            return (int)result;
        }
    }
}
