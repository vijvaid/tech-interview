using System;

namespace Solutions.Arrays;

public class ProductOfArrayExceptSelf_LeetCode
{
    public int[] productExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        result[0] = 1;
        for(int i = 1; i< nums.Length; i++)
        {
            result[i] = result[i-1] * nums[i-1];
        }

        int rightResult = 1;
        for(int i = nums.Length -1; i >=0; i--)
        {
            result[i] = result[i] * rightResult;
            rightResult *= nums[i];
        }

        return result;
    }
}
