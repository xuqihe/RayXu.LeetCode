using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCode lc = new LeetCode();

            ListNode head = new ListNode(1, null);
            int target = 1;

            var result = lc.RemoveNthFromEnd(head, target);
            Console.ReadLine();
        }
    }
}
