using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        public int StringToInteger(string str)
        {
            int digit = 1;
            long result = 0;

            // trim first empty char
            int idx = 0;
            for (; idx < str.Length && str[idx] == ' '; idx++)
            {
                // do nothing here
            }

            // check digit
            if (idx < str.Length)
            {
                if (str[idx] == '-')
                {
                    digit = -1;
                    idx++;
                }
                else if (str[idx] == '+')
                {
                    idx++;
                }
            }
            else
            {
                return 0;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>()
            {
                { '0', 0 } ,
                { '1', 1 } ,
                { '2', 2 } ,
                { '3', 3 } ,
                { '4', 4 } ,
                { '5', 5 } ,
                { '6', 6 } ,
                { '7', 7 } ,
                { '8', 8 } ,
                { '9', 9 } ,
            };

            for (; idx < str.Length; idx++)
            {
                if (dic.ContainsKey(str[idx]))
                {
                    result = result * 10 + dic[str[idx]];
                }
                else
                {
                    break;
                }

                if (result * digit > int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if (result * digit < int.MinValue)
                {
                    return int.MinValue;
                }
            }
            return (int)(result * digit);
        }
    }
}
