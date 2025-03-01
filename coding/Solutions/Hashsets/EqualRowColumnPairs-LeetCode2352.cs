using System;

namespace Solutions.Hashsets;

public class EqualRowColumnPairs
{
    public int EqualPairs(int[][] grid) 
    {
        int count = 0;

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach(var row in grid)
        {
            string rowString = string.Join(",", row);
            int value = 1;

            if(dictionary.ContainsKey(rowString))
            {
                value = dictionary[rowString] + 1;
            }
            dictionary[rowString] = value;
        }

        // n x n grid, hence number of rows and columns are same
        for(int columnIndex=0; columnIndex < grid.Length; columnIndex++)
        {
            string colString = "";
            for(int rowIndex=0; rowIndex < grid.Length; rowIndex++)
            {
                colString += grid[rowIndex][columnIndex] + ",";
            }
            colString = colString.TrimEnd(',');

            int value = 0;
            if(dictionary.TryGetValue(colString, out value))
            {
                count += value;
            }
        }

        return count;
        
    }
}
