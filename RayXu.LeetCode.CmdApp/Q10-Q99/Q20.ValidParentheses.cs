using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //An input string is valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.

        //Example 1:
        //Input: s = "()"
        //Output: true

        //Example 2:
        //Input: s = "()[]{}"
        //Output: true

        //Example 3:
        //Input: s = "(]"
        //Output: false

        //Example 4:
        //Input: s = "([)]"
        //Output: false

        //Example 5:
        //Input: s = "{[]}"
        //Output: true

        //Constraints:
        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.
        public bool ValidParentheses(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };

            Stack<char> stack = new Stack<char>();
            foreach (char chr in s)
            {
                if (dic.ContainsKey(chr))
                {
                    stack.Push(chr);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char pre = stack.Pop();
                        if (dic[pre] != chr)
                        {
                            return false;
                        }
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
