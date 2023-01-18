using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/squares-of-a-sorted-array/
 */
namespace Easy
{
    public class Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
