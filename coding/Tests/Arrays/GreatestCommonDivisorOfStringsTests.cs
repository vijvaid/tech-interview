using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class GreatestCommonDivisorOfStringsTests
    {
        private GreatestCommonDivisorOfStrings gcdOfStrings;

        [SetUp]
        public void Setup()
        {
            gcdOfStrings = new GreatestCommonDivisorOfStrings();
        }

        [Test]
        public void GcdOfStrings_Example1()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("ABCABC", "ABC"), Is.EqualTo("ABC"));
        }

        [Test]
        public void GcdOfStrings_Example2()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("ABABAB", "ABAB"), Is.EqualTo("AB"));
        }

        [Test]
        public void GcdOfStrings_Example3()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("LEET", "CODE"), Is.EqualTo(""));
        }

        [Test]
        public void GcdOfStrings_OneStringEmpty()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("", "ABC"), Is.EqualTo(""));
        }

        [Test]
        public void GcdOfStrings_BothStringsEmpty()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("", ""), Is.EqualTo(""));
        }

        [Test]
        public void GcdOfStrings_NoCommonDivisor()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("ABCD", "AB"), Is.EqualTo(""));
        }

        [Test]
        public void GcdOfStrings_SingleCharacterStrings_Equal()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("a", "a"), Is.EqualTo("a"));
        }

        [Test]
        public void GcdOfStrings_SingleCharacterStrings_Different()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("a", "b"), Is.EqualTo(""));
        }

        [Test]
        public void GcdOfStrings_MultipleDivisor()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("TAUXXTAUXXTAUXX", "TAUXXTAUXX"), Is.EqualTo("TAUXX"));
        }
        [Test]
        public void GcdOfStrings_OneStringIsMultipleOfTheOther()
        {
            Assert.That(gcdOfStrings.GcdOfStrings("ABABABAB", "ABAB"), Is.EqualTo("ABAB"));
        }
    }
}
