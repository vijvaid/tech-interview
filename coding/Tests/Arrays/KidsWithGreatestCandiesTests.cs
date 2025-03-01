using NUnit.Framework;
using Solutions.Arrays;
using System.Collections.Generic;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class KidsWithGreatestCandiesTests
    {
        private KidsWithGreatestCandies kidsWithCandies;

        [SetUp]
        public void Setup()
        {
            kidsWithCandies = new KidsWithGreatestCandies();
        }

        [Test]
        public void KidsWithCandies_Example1()
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            List<bool> expected = new List<bool> { true, true, true, false, true };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

        [Test]
        public void KidsWithCandies_Example2()
        {
            int[] candies = { 4, 2, 1, 1, 2 };
            int extraCandies = 1;
            List<bool> expected = new List<bool> { true, false, false, false, false };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

        [Test]
        public void KidsWithCandies_Example3()
        {
            int[] candies = { 12, 1, 12 };
            int extraCandies = 10;
            List<bool> expected = new List<bool> { true, false, true };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }
        
        [Test]
        public void KidsWithCandies_AllSameCandies()
        {
            int[] candies = { 5, 5, 5, 5 };
            int extraCandies = 2;
            List<bool> expected = new List<bool> { true, true, true, true };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

        [Test]
        public void KidsWithCandies_EmptyArray()
        {
            int[] candies = { };
            int extraCandies = 3;
            List<bool> expected = new List<bool> { };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

        [Test]
        public void KidsWithCandies_SingleKid()
        {
            int[] candies = { 10 };
            int extraCandies = 5;
            List<bool> expected = new List<bool> { true };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

        [Test]
        public void KidsWithCandies_ExtraCandiesZero()
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 0;
            List<bool> expected = new List<bool> { false, false, true, false, false };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }
        
        [Test]
         public void KidsWithCandies_AllKidsCanHaveGreatest()
        {
            int[] candies = { 1, 2, 3};
            int extraCandies = 10;
            List<bool> expected = new List<bool> { true, true, true };
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }
        [Test]
        public void KidsWithCandies_OneKidAlreadyHasGreatest()
        {
            int[] candies = {10, 5, 7};
            int extraCandies = 3;
            List<bool> expected = new List<bool> {true, false, true};
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));

        }
        [Test]
        public void KidsWithCandies_LargeNumbers()
        {
            int[] candies = { 1000, 500, 700, 2000};
            int extraCandies = 500;
            List<bool> expected = new List<bool> { false, false, false, true};
            Assert.That(kidsWithCandies.KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
        }

    }
}
