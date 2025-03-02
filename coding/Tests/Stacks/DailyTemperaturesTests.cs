namespace Solutions.Tests.Stacks;

using NUnit.Framework;
using Solutions.Stacks;

[TestFixture]
public class DailyTemperaturesTests
{
    [Test]
    public void Example1()
    {
        int[] temps = [73,74,75,71,69,72,76,73];
        int[] expected = [1,1,4,2,1,1,0,0];
        int[] actual = DailyTemperatures.GetDailyTemperatures(temps);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example2()
    {
        int[] temps = [30,40,50,60];
        int[] expected = [1,1,1,0];
        int[] actual = DailyTemperatures.GetDailyTemperatures(temps);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example3()
    {
        int[] temps = [30,60,90];
        int[] expected = [1,1,0];
        int[] actual = DailyTemperatures.GetDailyTemperatures(temps);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AllDescendingTemps()
    {
        int[] temps = [90,60,30];
        int[] expected = [0,0,0];
        int[] actual = DailyTemperatures.GetDailyTemperatures(temps);
        Assert.That(actual, Is.EqualTo(expected));
    }

}