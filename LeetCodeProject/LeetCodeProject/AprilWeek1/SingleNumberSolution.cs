/*
Given a non-empty array of integers, every element appears twice except for one. Find that single one.
Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
 */

using System.Linq;

namespace LeetCodeProject.AprilWeek1
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            // Normal Linq groupby solution
            var singleNumber = nums.GroupBy(r => r).Where(x => x.Count() == 1).Select(r => r.Key).First();
            return singleNumber;
        }

        /// <summary>
        /// reference by LeetCode Approach 4
        /// </summary>
        public int SingleNumber_XOR(int[] nums)
        {
            // XOR solution
            var solution = 0;
            foreach (var num in nums)
            {
                solution ^= num;
            }

            return solution;
        }
    }
}