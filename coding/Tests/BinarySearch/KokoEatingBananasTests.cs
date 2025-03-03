using NUnit.Framework;
using Solutions.BinarySearch;

namespace Solutions.Tests.BinarySearch
{
    [TestFixture]
    public class KokoEatingBananasTests
    {
        [TestCase(new[] { 3, 6, 7, 11 }, 8, 4)]
        [TestCase(new[] { 30, 11, 23, 4, 20 }, 5, 30)]
        [TestCase(new[] { 30, 11, 23, 4, 20 }, 6, 23)]
        [TestCase(new[] { 5 }, 2, 3)]
        [TestCase(new[] { 5 }, 1, 5)]
        [TestCase(new[] { 1, 2, 3 }, 6, 1)]
        [TestCase(new[] { 5, 5, 5 }, 3, 5)]
        [TestCase(new[] { 1000000000, 1000000000 }, 3, 1000000000)]
        [TestCase(new[] { 1, 1, 1, 1 }, 4, 1)]
        [TestCase(new[] { 1, 5, 10, 15 }, 6, 8)]
        [TestCase(new[] { 1, 1, 1, 1 }, 10000, 1)]
        [TestCase(new[] { 10, 20, 30, 40 }, 4, 40)]
        [TestCase(new[] { 1000000000, 1000000000, 1000000000 }, 4, 1000000000)]
        [TestCase(new[] { 1, 1000000000 }, 2, 1000000000)]
        public void MinEatingSpeed_VariousCases_ReturnsExpectedSpeed(int[] piles, int h, int expected)
        {
            int actual = KokoEatingBananas.MinEatingSpeed(piles, h);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
