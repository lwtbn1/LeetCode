using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class 寻找两个正序数组的中位数
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] sortedNums = 归并排序.Sort(nums1, nums2);
            if (sortedNums.Length == 0)
                return 0;
 
            double midVal = 0;
            int len = sortedNums.Length;
            if(sortedNums.Length % 2 == 0)
            {
                midVal = ((double)(sortedNums[len / 2 - 1]) + (double)(sortedNums[len / 2])) / 2f;
            }
            else
            {
                midVal = sortedNums[len / 2];
            }

            return midVal;
        }
    }
}
