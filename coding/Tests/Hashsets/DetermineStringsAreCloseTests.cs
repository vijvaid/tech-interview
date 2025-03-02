using NUnit.Framework;
using Solutions.Hashsets;

namespace Solutions.Tests.Hashsets;

public class DetermineStringsAreCloseTests
{
    private DetermineStringsAreClose determineStringsAreClose;

    [SetUp]
    public void SetUp()
    {
        determineStringsAreClose = new DetermineStringsAreClose();
    }

    [TestCase("abc", "bca", true)]
    [TestCase("a", "aa", false)]
    [TestCase("cabbba", "abbccc", true)]
    [TestCase("aaabbbbccddeeeeeff", "aaaaabbcccdeeefgggg", false)]
    [TestCase("abbccd", "bbdccaa", false)]
    [TestCase("uau", "ssx", false)]
    [TestCase("abc", "xyz", false)]
    [TestCase("aa", "bb", false)]
    [TestCase("", "", true)]
    [TestCase("a", "b", false)]
    [TestCase("zz", "zz", true)]
    [TestCase("z", "z", true)]
    [TestCase("acbc", "acbc", true)]
    public void CloseStrings_ShouldReturnExpectedResult(string word1, string word2, bool expected)
    {
        Assert.That(determineStringsAreClose.CloseStrings(word1, word2), Is.EqualTo(expected), "Words are {0}, {1}", word1, word2);
    }

    [Test]
    public void CloseStrings_DifferentLengths_ReturnsFalse()
    {
        Assert.That(determineStringsAreClose.CloseStrings("abc", "abcd"), Is.False);
    }

    [Test]
    public void CloseStrings_DifferentKeys_ReturnsFalse()
    {
        Assert.That(determineStringsAreClose.CloseStrings("abcd", "defd"), Is.False);
    }

    [Test]
    public void CloseStrings_DifferentKeyCounts_ReturnsFalse()
    {
        Assert.That(determineStringsAreClose.CloseStrings("aaab", "aabb"), Is.False);
    }

    [Test]
    public void CloseStrings_DifferentFrequencies_ReturnsTrue()
    {
        Assert.That(determineStringsAreClose.CloseStrings("abbc", "aabc"), Is.True);
    }

    [Test]
    public void CloseStrings_SameFrequencies_ReturnsTrue()
    {
        Assert.That(determineStringsAreClose.CloseStrings("cabbba", "abbccc"), Is.True);
    }

    [Test]
    public void CloseStrings_emptyStrings_ReturnsTrue()
    {
        Assert.That(determineStringsAreClose.CloseStrings("", ""), Is.True);
    }

    [Test]
    public void TestNonCloseStrings()
    {
        Assert.That(determineStringsAreClose.CloseStrings("abbzzca", "babzzcz"), Is.False);
    }
}
