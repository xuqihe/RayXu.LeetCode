using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
        //Notice that the solution set must not contain duplicate triplets.

        //Example 1:
        //Input: nums = [-1,0,1,2,-1,-4]
        //Output: [[-1,-1,2],[-1,0,1]]

        //Example 2:
        //Input: nums = []
        //Output: []

        //Example 3:
        //Input: nums = [0]
        //Output: []

        //Constraints:
        //0 <= nums.length <= 3000
        //-105 <= nums[i] <= 105

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> results = new List<IList<int>>();

            for (int left = 0; left < nums.Length - 2; left++)
            {
                if (left > 0 && nums[left] == nums[left - 1])
                {
                    continue;
                }

                for (int mid = left + 1, right = nums.Length - 1; mid < right;)
                {
                    int currentValue = nums[left] + nums[right] + nums[mid];
                    if (currentValue == 0)
                    {
                        results.Add(new List<int> { nums[left], nums[mid], nums[right] });
                        while (mid < right && nums[mid] == nums[mid + 1])
                        {
                            mid++;
                        }

                        while (mid < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        mid++;
                        right--;

                    }
                    else if (currentValue > 0)
                    {
                        right--;
                    }
                    else
                    {
                        mid++;
                    }
                }
            }

            return results;
        }
    }
}
