using System;

namespace Solutions.Arrays;

public class IncreasingTripletSubsequence_LeetCode334
{

    public bool IncreasingTriplet(int[] nums) {
        
        int firstMin = Int32.MaxValue;
        int secondMin = Int32.MaxValue;

        foreach(var num in nums)
        {
            if(num <= firstMin)
                firstMin = num;
            else if(num <= secondMin)
                secondMin = num;
            else
                return true;
        }

        return false;
    }
}
