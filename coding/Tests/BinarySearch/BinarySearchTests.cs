using NUnit.Framework;


namespace Solutions.Tests.BinarySearch
{
    [TestFixture]
    public class BinarySearchTests
    {
        [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [TestCase(new int[] { }, 5, -1)]
        [TestCase(new[] { 5 }, 5, 0)]
        [TestCase(new[] { 5 }, 10, -1)]
        [TestCase(new[] { 2, 5, 7, 8, 11, 12 }, 2, 0)]
        [TestCase(new[] { 2, 5, 7, 8, 11, 12 }, 12, 5)]
        [TestCase(new[] { -10, -5, 0, 5, 10 }, -5, 1)]
        public void Search_VariousCases_ReturnsExpectedIndex(int[] nums, int target, int expectedIndex)
        {
            int actualIndex = Solutions.BinarySearch.BinarySearch.Search(nums, target);
            Assert.That(actualIndex, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void Search_AllSameNumbers_TargetExists_ReturnsValidIndex()
        {
            int[] nums = { 5, 5, 5, 5, 5 };
            int target = 5;
            int actualIndex = Solutions.BinarySearch.BinarySearch.Search(nums, target);
            Assert.That(actualIndex, Is.InRange(0, nums.Length -1));
        }
    }
}
