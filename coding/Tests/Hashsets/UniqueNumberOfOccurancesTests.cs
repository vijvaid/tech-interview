using NUnit.Framework;
using Solutions.Hashsets;

namespace Solutions.Tests.Hashsets;

public class UniqueNumberOfOccurancesTests
{
    private UniqueNumberOfOccurances uniqueNumberOfOccurances;

    [SetUp]
    public void SetUp()
    {
        uniqueNumberOfOccurances = new UniqueNumberOfOccurances();
    }

    [Test]
    public void Example1()
    {
        int[] arr = { 1, 2, 2, 1, 1, 3 };
        bool expected = true;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example2()
    {
        int[] arr = { 1, 2 };
        bool expected = false;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example3()
    {
        int[] arr = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
        bool expected = true;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void EmptyArray()
    {
        int[] arr = { };
        bool expected = true;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void SingleElementArray()
    {
        int[] arr = { 5 };
        bool expected = true;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AllElementsSame()
    {
        int[] arr = { 5, 5, 5, 5 };
        bool expected = true;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void AllDifferentElementsSameOccurances()
    {
        int[] arr = { 1, 2, 3, 4, 5};
        bool expected = false;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DuplicateOccurances()
    {
        int[] arr = { 1, 1, 2, 2, 3, 3 };
        bool expected = false;
        bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
        public void NegativeNumbers()
        {
            int[] arr = {-1, -1, -2, -2, -3, -3};
            bool expected = false;
            bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
    [Test]
        public void MixedNumbers()
        {
            int[] arr = {-1, 1, -1, 1, 2, 2, 3, 3};
            bool expected = false;
            bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

    [Test]
        public void LargeNumber()
        {
            int[] arr = {1000000,1000000, 2, 2};
            bool expected = false;
            bool actual = uniqueNumberOfOccurances.UniqueOccurrences(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }
}
