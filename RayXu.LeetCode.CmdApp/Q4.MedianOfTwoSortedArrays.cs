using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.LeetCode.CmdApp
{
    partial class LeetCode
    {
        //There are two sorted arrays nums1 and nums2 of size m and n respectively.
        //Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
        //You may assume nums1 and nums2 cannot be both empty.

        //Example 1:
        //nums1 = [1, 3]
        //nums2 = [2]
        //The median is 2.0

        //Example 2:
        //nums1 = [1, 2]
        //nums2 = [3, 4]
        //The median is (2 + 3)/2 = 2.5
        public double FindMedianSortedArrays(int[] numsA, int[] numsB)
        {
            int lengthA = numsA.Length;
            int lengthB = numsB.Length;

            // make sure lenghA is smaller
            if (lengthA > lengthB)
            {
                int[] temp = numsA;
                numsA = numsB;
                numsB = temp;

                int tempLenght = lengthA;
                lengthA = lengthB;
                lengthB = tempLenght;
            }

            // see the half length value
            int iLow = 0;
            int iHigh = lengthA;
            int halfLengh = lengthA / 2 + lengthB / 2 + (((lengthA & 1) | (lengthB & 1)) & 1);
            while (iLow <= iHigh)
            {
                // split each nums to 2 parts
                // make sure the nums1[i-1]< nums2[j], nums1[i]>nums2[j-1]
                int i = iHigh + (iLow - iHigh) / 2;
                int j = halfLengh - i;

                if (i < iHigh && numsA[i] < numsB[j - 1])
                {
                    // i is small
                    iLow = i + 1;
                }
                else if (i > iLow && numsA[i - 1] > numsB[j])
                {
                    // i is big
                    iHigh = i - 1;
                }
                else
                {
                    // get max left part
                    int maxLeft = 0;
                    if (i == 0)
                    {
                        maxLeft = numsB[j - 1];
                    }
                    else if (j == 0)
                    {
                        maxLeft = numsA[i - 1];
                    }
                    else
                    {
                        maxLeft = numsA[i - 1] > numsB[j - 1] ? numsA[i - 1] : numsB[j - 1];
                    }

                    // check odd or even
                    if ((((lengthA & 1) + (lengthB & 1)) & 1) == 1)
                    {
                        return maxLeft;
                    }

                    // get min right
                    int minRight = 0;
                    if (i == lengthA)
                    {
                        minRight = numsB[j];
                    }
                    else if (j == lengthB)
                    {
                        minRight = numsA[i];
                    }
                    else
                    {
                        minRight = numsA[i] < numsB[j] ? numsA[i] : numsB[j];
                    }

                    return ((double)(minRight + maxLeft)) / 2;
                }
            }

            return 0;
        }
    }
}
