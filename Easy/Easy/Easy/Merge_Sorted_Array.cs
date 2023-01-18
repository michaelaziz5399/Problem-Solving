using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * https://leetcode.com/problems/merge-sorted-array/
 */
namespace Easy
{
    public class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1.Length > 0 && nums2.Length > 0)
            {
                int countNums2 = nums2.Length - 1;
                int countNums1 = nums1.Length - 1;
                while (countNums1 >= 0 && countNums2 >= 0 && nums1[countNums1] == 0)
                {
                    nums1[countNums1] = nums2[countNums2];
                    countNums1--;
                    countNums2--;
                }
                Array.Sort(nums1);
            }

        }
    }
}
