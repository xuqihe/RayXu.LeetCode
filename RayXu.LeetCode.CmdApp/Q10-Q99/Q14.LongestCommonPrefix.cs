using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".

        //Example 1:
        //Input: ["flower","flow","flight"]
        //Output: "fl"

        //Example 2:
        //Input: ["dog","racecar","car"]
        //Output: ""
        //Explanation: There is no common prefix among the input strings.

        //Note:
        //All given inputs are in lowercase letters a-z.
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(strs[0]))
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < strs[0].Length; i++)
            {
                char chr = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != chr)
                    {
                        return result.ToString();
                    }
                }
                result.Append(chr);
            }

            return result.ToString();
        }
    }
}
