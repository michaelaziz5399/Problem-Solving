using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/move-zeroes/
 */
namespace Easy
{
    public class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length > 1)
            {
                int end = nums.Length;
                for (int i = 0; i < end; i++)
                {
                    if (nums[i] == 0)
                    {
                        for (int j = i; j < end - 1; j++)
                        {
                            nums[j] = nums[j + 1];
                        }
                        nums[end - 1] = 0;
                        end--;
                        i--;
                    }

                }
            }
        }
    }
}
