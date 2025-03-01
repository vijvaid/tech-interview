using NUnit.Framework;
using Solutions.Hashsets;
using System.Collections.Generic;

namespace Solutions.Tests.Hashsets;

public class FindDifferenceOfTwoArraysTests
{
    private FindDifferenceOfTwoArrays findDifferenceOfTwoArrays;

    [SetUp]
    public void SetUp()
    {
        findDifferenceOfTwoArrays = new FindDifferenceOfTwoArrays();
    }

    [Test]
    public void Example1()
    {
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { 2, 4, 6 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { 1, 3 },
            new List<int> { 4, 6 }
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }

    [Test]
    public void Example2()
    {
        int[] nums1 = { 1, 2, 3, 3 };
        int[] nums2 = { 1, 1, 2, 2 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { 3 },
            new List<int>()
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }
    
    [Test]
    public void EmptyArrays()
    {
        int[] nums1 = { };
        int[] nums2 = { };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(),
            new List<int>()
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }
     [Test]
    public void FirstArrayEmpty()
    {
        int[] nums1 = { };
        int[] nums2 = { 1, 2, 3 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(),
            new List<int>() {1,2,3}
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }
    [Test]
    public void SecondArrayEmpty()
    {
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(){1,2,3},
            new List<int>()
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }

    [Test]
    public void IdenticalArrays()
    {
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { 1, 2, 3 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(),
            new List<int>()
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }
    
    [Test]
    public void DuplicateNumbersInBoth()
    {
         int[] nums1 = {1, 2, 2, 3, 4};
        int[] nums2 = {2, 3, 3, 5, 6};

        IList<IList<int>> expected = new List<IList<int>>{
           new List<int>() {1,4},
            new List<int>(){5,6}
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }

    [Test]
    public void NegativeNumbers()
    {
        int[] nums1 = { -1, -2, -3 };
        int[] nums2 = { -2, -4, -6 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { -1, -3 },
            new List<int> { -4, -6 }
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }

    [Test]
    public void MixedPositiveAndNegativeNumbers()
    {
        int[] nums1 = { -1, 2, -3 };
        int[] nums2 = { 2, 4, -6 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { -1, -3 },
            new List<int> { 4, -6 }
        };

        IList<IList<int>> actual = findDifferenceOfTwoArrays.FindDifference(nums1, nums2);

        Assert.That(actual[0], Is.EquivalentTo(expected[0]));
        Assert.That(actual[1], Is.EquivalentTo(expected[1]));
    }
}
