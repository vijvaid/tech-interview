using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class ProductOfArrayExceptSelfTests
    {
        private ProductOfArrayExceptSelf_LeetCode productOfArray;

        [SetUp]
        public void Setup()
        {
            productOfArray = new ProductOfArrayExceptSelf_LeetCode();
        }

        [Test]
        public void ProductExceptSelf_Example1()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 24, 12, 8, 6 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_Example2()
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] expected = { 0, 0, 9, 0, 0 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_AllPositiveNumbers()
        {
            int[] nums = { 2, 3, 4, 5 };
            int[] expected = { 60, 40, 30, 24 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_AllNegativeNumbers()
        {
            int[] nums = { -2, -3, -4, -5 };
            int[] expected = { -60, -40, -30, -24 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_MixedPositiveAndNegativeNumbers()
        {
            int[] nums = { -2, 3, -4, 5 };
            int[] expected = { -60, 40, -30, 24 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_SingleZero()
        {
            int[] nums = { 1, 2, 0, 4 };
            int[] expected = { 0, 0, 8, 0 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_MultipleZeros()
        {
            int[] nums = { 1, 0, 2, 0 };
            int[] expected = { 0, 0, 0, 0 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_SingleElement()
        {
            int[] nums = { 5 };
            int[] expected = { 1 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_TwoElements()
        {
            int[] nums = { 2, 3 };
            int[] expected = { 3, 2 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }
         [Test]
        public void ProductExceptSelf_ZerosEverywhere()
        {
            int[] nums = { 0, 0, 0, 0};
            int[] expected = { 0, 0, 0, 0 };
            Assert.That(productOfArray.productExceptSelf(nums), Is.EqualTo(expected));
        }
        
    }
}
