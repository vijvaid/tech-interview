using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class CanPlaceFlowersTests
    {
        private CanPlaceFlowersClass canPlaceFlowers;

        [SetUp]
        public void Setup()
        {
            canPlaceFlowers = new CanPlaceFlowersClass();
        }

        [Test]
        public void CanPlaceFlowers_Example1()
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }

        [Test]
        public void CanPlaceFlowers_Example2()
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 2;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }

        [Test]
        public void CanPlaceFlowers_SinglePlot_Empty()
        {
            int[] flowerbed = { 0 };
            int n = 1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }

        [Test]
        public void CanPlaceFlowers_SinglePlot_Occupied()
        {
            int[] flowerbed = { 1 };
            int n = 1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }

        [Test]
        public void CanPlaceFlowers_AllEmpty()
        {
            int[] flowerbed = { 0, 0, 0, 0, 0 };
            int n = 2;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }

        [Test]
        public void CanPlaceFlowers_AllOccupied()
        {
            int[] flowerbed = { 1, 1, 1, 1, 1 };
            int n = 1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }

        [Test]
        public void CanPlaceFlowers_EmptyFlowerbed_ZeroToPlant()
        {
            int[] flowerbed = { };
            int n = 0;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }
         [Test]
        public void CanPlaceFlowers_MiddlePlaceAvailable()
        {
             int[] flowerbed = {1,0,0,0,0,0,1};
             int n = 2;
             Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }
          [Test]
        public void CanPlaceFlowers_MiddlePlaceNotAvailable()
        {
             int[] flowerbed = {1,0,1,0,0,0,1};
             int n = 2;
             Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }
        
        [Test]
        public void CanPlaceFlowers_MultiplePlacesAvailable()
        {
            int[] flowerbed = {0,0,0,0,0,0};
            int n = 3;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }
        [Test]
        public void CanPlaceFlowers_MultiplePlacesAvailable_notEnough()
        {
            int[] flowerbed = {0,0,0,0,0,0};
            int n = 4;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }

        [Test]
        public void CanPlaceFlowers_EdgeCase_NearEdge()
        {
            int[] flowerbed = { 0, 0, 1, 0, 0 };
            int n = 1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }

        [Test]
        public void CanPlaceFlowers_LargeFlowerbed()
        {
            int[] flowerbed = {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0};
            int n = 10;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.True);
        }

        [Test]
        public void CanPlaceFlowers_NegativeN_ReturnsFalse()
        {
            int[] flowerbed = {1,0,0,0,0};
            int n = -1;
            Assert.That(canPlaceFlowers.CanPlaceFlowers(flowerbed, n), Is.False);
        }

    }
}
