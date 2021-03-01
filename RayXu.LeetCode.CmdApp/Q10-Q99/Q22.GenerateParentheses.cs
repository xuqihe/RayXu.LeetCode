using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

        //Example 1:
        //Input: n = 3
        //Output: ["((()))","(()())","(())()","()(())","()()()"]

        //Example 2:
        //Input: n = 1
        //Output: ["()"]

        //Constraints:
        //1 <= n <= 8
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> results = new List<string>();
            GenerateParenthesisHelper(string.Empty, 0, 0, n, results);
            return results;
        }

        private static void GenerateParenthesisHelper(string cur, int left, int right, int num, IList<string> results)
        {
            if (left == right && left == num)
            {
                results.Add(cur);
                return;
            }

            if (left < num)
            {
                GenerateParenthesisHelper(cur + "(", left + 1, right, num, results);
            }

            if (left > right)
            {
                GenerateParenthesisHelper(cur + ")", left, right + 1, num, results);
            }
        }
    }
}
