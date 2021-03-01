using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given the head of a linked list, remove the nth node from the end of the list and return its head.

        //Follow up: Could you do this in one pass?

        //Example 1:
        //Input: head = [1, 2, 3, 4, 5], n = 2
        //Output: [1,2,3,5]

        //Example 2:
        //Input: head = [1], n = 1
        //Output: []

        //Example 3:
        //Input: head = [1, 2], n = 1
        //Output: [1]

        //Constraints:
        //The number of nodes in the list is sz.
        //1 <= sz <= 30
        //0 <= Node.val <= 100
        //1 <= n <= sz
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // create a empty node p, p.next point to head
            ListNode start = new ListNode(0, head);
            ListNode p = new ListNode(0, start);
            ListNode q = new ListNode(0, start);
            

            // move n steps
            for (int index = 0; index < n; index++)
            {
                p = p.Next;
            }

            // move p to end
            while (p.Next != null)
            {
                p = p.Next;
                q = q.Next;
            }

            // remove q.next;
            q.Next = q.Next.Next;
            return start.Next;
        }
    }
}
