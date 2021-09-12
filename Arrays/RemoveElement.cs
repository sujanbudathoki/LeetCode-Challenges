using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenges.LeetCode_Challenges.Arrays
{
  public  class RemoveElement
    {
        public int RemoveElementAt(int[] nums,int val)
        {
            int contains=0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    contains++;
            }
            return nums.Length - contains;


        }
    }
}
