using System;
using Solutions.Hashsets;

namespace Solutions.Tests.Hashsets;

[TestFixture]
public class EqualRowColumnPairsTests
{
    private EqualRowColumnPairs equalRowColumnPairs;

    [SetUp]
    public void SetUp()
    {
        equalRowColumnPairs = new EqualRowColumnPairs();
    }

    [Test]
    public void MultipleEqualPairsTest()
    {
        int[][] testData = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(3));
    }

    [Test]
    public void NoEqualPairsTest()
    {
        int[][] testData = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(0));
    }

    [Test]
    public void AllSameTest()
    {
        int[][] testData = [[1, 1, 1], [1, 1, 1], [1, 1, 1]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(9));
    }

    [Test]
    public void EmptyGridTest()
    {
        int[][] testData = [];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(0));
    }

    [Test]
    public void SingleElementGridTest()
    {
        int[][] testData = [[5]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(1));
    }

    [Test]
    public void GridWithDuplicateRowsAndColumns()
    {
        int[][] testData =
        [
            [1, 2, 1],
            [2, 1, 2],
            [1, 2, 1]
        ];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(5));
    }
    [Test]
    public void DifferentGridSizes()
    {
            int[][] testData =
        [
            [1,2],
            [2,1]
        ];
            Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(2));
    }

    [Test]
    public void NegativeNumbersGrid()
    {
        int[][] testData = [[-1, -2], [-2, -1]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(2));
    }
    
    [Test]
    public void MixedNegativeAndPositiveNumbersGrid()
    {
        int[][] testData = [[-1, 2], [2, -1]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(2));
    }

     [Test]
    public void LargeNumbersGrid()
    {
        int[][] testData = [[1000000000, 2000000000], [2000000000, 1000000000]];
        Assert.That(equalRowColumnPairs.EqualPairs(testData), Is.EqualTo(2));
    }
}
