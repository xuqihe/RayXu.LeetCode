using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp.Q10_Q99
{
    partial class LeetCode
    {
        // Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate(i, ai). n vertical lines are drawn such that the two endpoints of line i is at(i, ai) and(i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
        // Note: You may not slant the container and n is at least 2.

        //The above vertical lines are represented by array[1, 8, 6, 2, 5, 4, 8, 3, 7]. In this case, the max area of water (blue section) the container can contain is 49.
        //Example:
        //Input: [1,8,6,2,5,4,8,3,7]
        //Output: 49
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            int maxAera = 0;
            for (int i = 0, j = height.Length - 1; i < j;)
            {
                maxAera = Math.Max(maxAera, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxAera;
        }
    }
}
