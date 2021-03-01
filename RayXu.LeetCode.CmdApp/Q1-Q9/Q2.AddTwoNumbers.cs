using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Example:
        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode p = result;

            int digit = 0;
            while (l1 != null || l2 != null || digit > 0)
            {
                // get two value
                int value1 = 0;
                int value2 = 0;
                if (l1 != null)
                {
                    value1 = l1.Val;
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    value2 = l2.Val;
                    l2 = l2.Next;
                }

                // sum with digit
                int sum = value1 + value2 + digit;
                if (sum >= 10)
                {
                    sum -= 10;
                    digit = 1;
                }
                else
                {
                    digit = 0;
                }

                // create the value node, move the point to the higher digit
                ListNode node = new ListNode(sum);
                p.Next = node;
                p = p.Next;
            }

            // remove the first empty node
            result = result.Next;
            return result;
        }
    }
}
