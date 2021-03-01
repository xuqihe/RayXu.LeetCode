using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.Return the answer in any order.
        //A mapping of digit to letters (just like on the telephone buttons) is given below.Note that 1 does not map to any letters.

        //Example 1:
        //Input: digits = "23"
        //Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

        //Example 2:
        //Input: digits = ""
        //Output: []

        //Example 3:
        //Input: digits = "2"
        //Output: ["a","b","c"]

        //Constraints:
        //0 <= digits.length <= 4
        //digits[i] is a digit in the range ['2', '9'].
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> results = new List<string>();
            if (digits.Length != 0)
            {
                LetterCombinationsHelper(digits, 0, string.Empty, results);
            }
            return results;
        }

        private void LetterCombinationsHelper(string digits, int index, string current, IList<string> results)
        {
            if (index > digits.Length - 1)
            {
                results.Add(current);
                return;
            }

            for (int numberCharIndex = 0; numberCharIndex < PhoneNumberMap[digits[index].ToString()].Length; numberCharIndex++)
            {
                LetterCombinationsHelper(digits, index + 1, current + PhoneNumberMap[digits[index].ToString()][numberCharIndex], results);
            }
        }

        private static Dictionary<string, string> PhoneNumberMap = new Dictionary<string, string>
        {
            { "2", "abc" },
            { "3", "def" },
            { "4", "ghi" },
            { "5", "jkl" },
            { "6", "mno" },
            { "7", "pqrs" },
            { "8", "tuv" },
            { "9", "wxyz" },
        };
    }
}
