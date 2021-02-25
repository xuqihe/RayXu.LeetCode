using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target.Return the sum of the three integers.You may assume that each input would have exactly one solution.

        //Example 1:
        //Input: nums = [-1,2,1,-4], target = 1
        //Output: 2
        //Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

        //Constraints:
        //3 <= nums.length <= 10^3
        //-10^3 <= nums[i] <= 10^3
        //-10^4 <= target <= 10^4

        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int dif = int.MaxValue, reslut = 0;

            for (int left = 0; left < nums.Length - 2; left++)
            {
                if (left > 0 && nums[left] == nums[left - 1])
                {
                    continue;
                }

                for (int mid = left + 1, right = nums.Length - 1; mid < right;)
                {
                    int sum = nums[left] + nums[mid] + nums[right];

                    if (sum == target)
                    {
                        return target;
                    }
                    else
                    {
                        int abs = Math.Abs(target - sum);
                        if (abs < dif)
                        {
                            dif = abs;
                            reslut = sum;
                        }

                        if (sum > target)
                        {
                            right--;
                        }
                        else
                        {
                            mid++;
                        }
                    }
                }
            }

            return reslut;
        }
    }
}
