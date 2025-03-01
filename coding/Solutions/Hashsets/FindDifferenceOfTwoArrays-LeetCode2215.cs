namespace Solutions.Hashsets;

public class FindDifferenceOfTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
 
        var list1Exclusive = new List<int>();
        var setNums2 = new HashSet<int>(nums2);
        foreach(var num in nums1)
        {
            if(!setNums2.Contains(num) && !list1Exclusive.Contains(num))
            {
                list1Exclusive.Add(num);
            }
        }

        var list2Exclusive = new List<int>();
        var setNums1 = new HashSet<int>(nums1);
        foreach(var num in nums2)
        {
            if(!setNums1.Contains(num) && !list2Exclusive.Contains(num))
            {
                list2Exclusive.Add(num);
            }
        }

        return [list1Exclusive, list2Exclusive];
    }
}