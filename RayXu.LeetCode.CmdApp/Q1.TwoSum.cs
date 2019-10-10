using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //Example:
        //Given nums = [2, 7, 11, 15], target = 9,
        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].
        public int[] TwoSum(int[] nums, int target)
        {
            // create a dictionary to store the num and the position
            // may contains same num at different position
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], new HashSet<int> { i });
                }
                else
                {
                    dic[nums[i]].Add(i);
                }
            }

        foreach (var num in dic)
        {
            // subValue = target - firstValue
            int subValue = target - num.Key;

            if (dic.ContainsKey(subValue))
            {
                HashSet<int> subIdxs = dic[subValue];

                // firstValue = subValue
                if (num.Key == subValue)
                {
                    if (subIdxs.Count > 1)
                    {
                        return subIdxs.Take(2).ToArray();
                    }
                }
                else
                {
                    return new[] { num.Value.First(), subIdxs.First() };
                }
            }
        }

        // not found
        return null;
        }
    }
}
