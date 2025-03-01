using System;

namespace Solutions.Arrays;

public class KidsWithGreatestCandies
{
public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

        var greatest = -1;
        var n = candies.Length;

        // Find current greatest
        foreach(var candy in candies)
        {
            if(candy > greatest)
            {
                greatest = candy;
            }
        }

        List<bool> output = new List<bool>();

        for(int i = 0; i < n; i++)
        {
            output.Add((candies[i] + extraCandies) >= greatest ? true : false);
        }

        return output;
    }
}
