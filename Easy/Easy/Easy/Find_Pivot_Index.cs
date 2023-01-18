using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/find-pivot-index/
 */
namespace Easy
{
    public class Find_Pivot_Index
    {
        public int PivotIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || i == nums.Length - 1)
                {
                    int sum = 0;
                    if (i == 0)
                    {
                        for (int right = 1; right < nums.Length; right++)
                        {
                            sum += nums[right];
                        }
                        if (sum == 0)
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        for (int left = nums.Length - 2; left >= 0; left--)
                        {
                            sum += nums[left];
                        }
                        if (sum == 0)
                        {
                            return i;
                        }
                    }

                }
                else
                {
                    int rightSum = 0;
                    int leftSum = 0;
                    for (int right = i + 1; right < nums.Length; right++)
                    {
                        rightSum += nums[right];
                    }
                    for (int left = i - 1; left >= 0; left--)
                    {
                        leftSum += nums[left];
                    }
                    if (rightSum == leftSum)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
