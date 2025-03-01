using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class IncreasingTripletSubsequenceTests
    {
        private IncreasingTripletSubsequence_LeetCode334 tripletSubsequence;

        [SetUp]
        public void Setup()
        {
            tripletSubsequence = new IncreasingTripletSubsequence_LeetCode334();
        }

        [Test]
        public void IncreasingTriplet_Example1()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }

        [Test]
        public void IncreasingTriplet_Example2()
        {
            int[] nums = { 5, 4, 3, 2, 1 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_Example3()
        {
            int[] nums = { 2, 1, 5, 0, 4, 6 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }

        [Test]
        public void IncreasingTriplet_EmptyArray()
        {
            int[] nums = { };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_SingleElement()
        {
            int[] nums = { 1 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_TwoElements_Increasing()
        {
            int[] nums = { 1, 2 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_TwoElements_Decreasing()
        {
            int[] nums = { 2, 1 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_ThreeElements_Increasing()
        {
            int[] nums = { 1, 2, 3 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }

        [Test]
        public void IncreasingTriplet_ThreeElements_Decreasing()
        {
            int[] nums = { 3, 2, 1 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_LongerArray_NoTriplet()
        {
            int[] nums = { 5, 4, 3, 2, 1, 0, -1, -2, -3 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }
        [Test]
        public void IncreasingTriplet_LongerArray_WithTriplet()
        {
            int[] nums = { 5, 4, 3, 2, -1, 0, -2, 10 };
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }
        [Test]
        public void IncreasingTriplet_TripletAtStart()
        {
            int[] nums = {1, 2, 3, 0, 0, 0};
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }

        [Test]
        public void IncreasingTriplet_TripletAtEnd()
        {
            int[] nums = {0, 0, 0, 1, 2, 3};
             Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }

        [Test]
        public void IncreasingTriplet_RepeatedNumbers()
        {
            int[] nums = {1, 1, 1, 1, 1};
            Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.False);
        }

        [Test]
        public void IncreasingTriplet_RepeatedNumbers_WithTriplet()
        {
            int[] nums = {1, 1, 1, 2, 1, 1, 3};
             Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }
        
        [Test]
        public void IncreasingTriplet_NegativeNumbers()
        {
            int[] nums = { -5, -4, -3, -2, -1 };
             Assert.That(tripletSubsequence.IncreasingTriplet(nums), Is.True);
        }
    }
}
