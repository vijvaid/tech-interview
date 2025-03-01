using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class MergeStringsAlternatelyTests
    {
        private MergeStringsAlternately merger;

        [SetUp]
        public void Setup()
        {
            merger = new MergeStringsAlternately();
        }

        [Test]
        public void MergeAlternately_BothWordsSameLength_ReturnsMergedString()
        {
            Assert.That(merger.MergeAlternately("abc", "pqr"), Is.EqualTo("apbqcr"));
        }

        [Test]
        public void MergeAlternately_Word1Longer_ReturnsMergedString()
        {
            Assert.That(merger.MergeAlternately("abcd", "pq"), Is.EqualTo("apbqcd"));
        }

        [Test]
        public void MergeAlternately_Word2Longer_ReturnsMergedString()
        {
            Assert.That(merger.MergeAlternately("ab", "pqrs"), Is.EqualTo("apbqrs"));
        }

        [Test]
        public void MergeAlternately_Word1Empty_ReturnsWord2()
        {
            Assert.That(merger.MergeAlternately("", "xyz"), Is.EqualTo("xyz"));
        }

        [Test]
        public void MergeAlternately_Word2Empty_ReturnsWord1()
        {
            Assert.That(merger.MergeAlternately("xyz", ""), Is.EqualTo("xyz"));
        }

        [Test]
        public void MergeAlternately_BothEmpty_ReturnsWord1()
        {
            Assert.That(merger.MergeAlternately("", ""), Is.EqualTo(""));
        }

        [Test]
        public void MergeAlternately_BothWordsEmpty_ReturnsEmptyString()
        {
            Assert.That(merger.MergeAlternately("", ""), Is.EqualTo(""));
        }

        [Test]
        public void MergeAlternately_SingleLetterWords_ReturnsMergedString()
        {
            Assert.That(merger.MergeAlternately("a", "b"), Is.EqualTo("ab"));
        }
    }
}
