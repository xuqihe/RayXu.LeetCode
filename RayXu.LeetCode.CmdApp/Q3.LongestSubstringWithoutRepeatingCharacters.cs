using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given a string, find the length of the longest substring without repeating characters.

        //Example 1:
        //Input: "abcabcbb"
        //Output: 3 
        //Explanation: The answer is "abc", with the length of 3. 

        //Example 2:
        //Input: "bbbbb"
        //Output: 1
        //Explanation: The answer is "b", with the length of 1.

        //Example 3:
        //Input: "pwwkew"
        //Output: 3
        //Explanation: The answer is "wke", with the length of 3. 
        //Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
        public int LengthOfLongestSubstring(string s)
        {
            List<char> currentString = new List<char>();
            HashSet<char> hsCurrentString = new HashSet<char>();
            int currentCount = 0;
            int maxCount = 0;

            foreach (char chr in s)
            {
                if (!hsCurrentString.Contains(chr))
                {
                    // add the chr to the list
                    currentCount++;
                    currentString.Add(chr);
                    hsCurrentString.Add(chr);
                }
                else
                {
                    // remove the firt chr, untill equal to the current chr
                    while (currentString.ElementAt(0) != chr)
                    {
                        currentCount--;
                        hsCurrentString.Remove(currentString[0]);
                        currentString.RemoveAt(0);
                    }

                    // remove the first chr, add to last
                    currentString.RemoveAt(0);
                    currentString.Add(chr);
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }
    }
}
