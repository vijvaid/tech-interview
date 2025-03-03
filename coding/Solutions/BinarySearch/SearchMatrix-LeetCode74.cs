using System;
using System.Security.AccessControl;

namespace Solutions.BinarySearch;

public class SearchMatrix
{
    public static bool Search2DMatrix(int[][] matrix, int target)
    {
        int left = 0;
        int right = matrix.Length - 1; // rowCount
        int result = -1;

        while (left <= right)
        {
            int mid = (int)(left + right) / 2;
            int[] row = matrix[mid];

            if (target < row[0])
            {
                right = mid - 1;
            }
            else if (target > row[row.Length - 1])
            {
                left = mid + 1;
            }
            else
            {
                result = BinarySearch.Search(row, target);
                break;
            }
        }

        return result != -1;
    }
}
