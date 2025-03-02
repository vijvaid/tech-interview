using NUnit.Framework;
using Solutions.Stacks;

namespace Solutions.Tests.Stacks;

public class RemoveStarsFromStringTests
{
    private RemoveStarsFromString removeStarsFromString;

    [SetUp]
    public void Setup()
    {
        removeStarsFromString = new RemoveStarsFromString();
    }

    [Test]
    public void Example1()
    {
        string s = "leet**cod*e";
        string expected = "lecoe";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example2()
    {
        string s = "erase*****";
        string expected = "";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void EmptyString()
    {
        string s = "";
        string expected = "";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void NoStars()
    {
        string s = "abcdefg";
        string expected = "abcdefg";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AllStars()
    {
        string s = "*******";
        string expected = "";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void StarAtBeginning()
    {
        string s = "*abc";
        string expected = "abc";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void StarAtEnd()
    {
        string s = "abc*";
        string expected = "ab";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void MultipleStarsTogether()
    {
        string s = "abc****def";
        string expected = "def";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void SingleStar()
    {
        string s = "*";
        string expected = "";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void MultipleStarsAndCharacters()
    {
        string s = "a*b*c*d";
        string expected = "d";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void MultipleStarsAndCharacters2()
    {
        string s = "a**b*c";
        string expected = "c";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void MultipleStarsAndCharacters3()
    {
        string s = "a***bc";
        string expected = "bc";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void LongStringWithMultipleStars()
    {
        string s = "abcdefghijklmnop***qrstuvwxyza**bcdefgh";
        string expected = "abcdefghijklmqrstuvwxybcdefgh";
        string actual = removeStarsFromString.RemoveStars(s);
        Assert.That(actual, Is.EqualTo(expected));

    }
}
