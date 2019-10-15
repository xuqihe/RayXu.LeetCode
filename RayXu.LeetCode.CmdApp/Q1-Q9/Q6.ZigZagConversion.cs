using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
        //(you may want to display this pattern in a fixed font for better legibility)
        //P   A   H   N
        //A P L S I I G
        //Y   I   R
        //And then read line by line: "PAHNAPLSIIGYIR"
        //Write the code that will take a string and make this conversion given a number of rows:
        //string convert(string s, int numRows);

        //Example 1:
        //Input: s = "PAYPALISHIRING", numRows = 3
        //Output: "PAHNAPLSIIGYIR"

        //Example 2:
        //Input: s = "PAYPALISHIRING", numRows = 4
        //Output: "PINALSIGYAHRPI"
        //Explanation:
        //P     I    N
        //A   L S  I G
        //Y A   H R
        //P     I
        public string ZigZagConvert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s) || numRows == 1)
            {
                return s;
            }

            int circleLength = 2 * (numRows - 1);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < s.Length; j += circleLength)
                {
                    result.Append(s[i + j]);
                    if (i != 0 && i != numRows - 1 && j + circleLength - i < s.Length)
                    {
                        result.Append(s[j + circleLength - i]);
                    }
                }
            }
            return result.ToString();
        }
    }
}
