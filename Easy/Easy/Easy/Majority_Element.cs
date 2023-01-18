using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/majority-element/
 */
namespace Easy
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int index = 0;
            int resCount = 0;
            int maxCount = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                maxCount = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        maxCount++;
                    }
                }
                if (maxCount > resCount)
                {
                    resCount = maxCount;
                    index = i;
                }
            }

            return nums[index];
        }
    }
}
