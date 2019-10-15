using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            int maxLength = 0;
            int position = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int length1 = FindPalindromeStringLength(s, i, i);
                int length2 = FindPalindromeStringLength(s, i, i + 1);
                int length = Math.Max(length1, length2);

                if (length > maxLength)
                {
                    maxLength = length;
                    position = i;
                }
            }
            return s.Substring(position - (maxLength - 1) / 2, maxLength);
        }


        private int FindPalindromeStringLength(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
