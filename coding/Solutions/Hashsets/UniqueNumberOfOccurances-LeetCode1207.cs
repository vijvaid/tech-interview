using System.Collections.Generic;

namespace Solutions.Hashsets;

public class UniqueNumberOfOccurances
{
    public bool UniqueOccurrences(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        var set = new HashSet<int>();
        foreach (var value in dict.Values)
        {
            if (set.Contains(value))
            {
                return false;
            }
            set.Add(value);
        }

        return true;
    }
}
