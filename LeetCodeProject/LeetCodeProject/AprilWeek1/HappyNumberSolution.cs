/*
Write an algorithm to determine if a number n is "happy".

A happy number is a number defined by the following process: Starting with any positive integer, 
replace the number by the sum of the squares of its digits, 
and repeat the process until the number equals 1 (where it will stay), 
or it loops endlessly in a cycle which does not include 1. 
Those numbers for which this process ends in 1 are happy numbers.

Return True if n is a happy number, and False if not.

Example: 

Input: 19
Output: true
Explanation: 
1^2 + 9^2 = 82
8^2 + 2^2 = 68
6^2 + 8^2 = 100
1^2 + 0^2 + 0^2 = 1
 */

using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProject.AprilWeek1
{
    public class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {
            var endValue = n;
            var appearedValues = new HashSet<int>();
            do
            {
                var numString = endValue.ToString();
                var judgeValue = numString.Sum(r => (r - '0') * (r - '0'));
                if (appearedValues.Contains(judgeValue))
                    return false;

                if (judgeValue == 1)
                    return true;

                endValue = judgeValue;
                appearedValues.Add(judgeValue);
            } while (true);
        }
    }
}