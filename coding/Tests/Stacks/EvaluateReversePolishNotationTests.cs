namespace Solutions.Tests.Stacks;

using NUnit.Framework;
using Solutions.Stacks;

[TestFixture]
public class TestPolishNotationTests
{
    [Test]
    public void Example1()
    {
        string[] tokens = ["2","1","+","3","*"];
        int actual = EvaluateReversePolishNotation.EvalRPN(tokens);
        int expected = 9;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example2()
    {
        string[] tokens = ["4","13","5","/","+"];
        int actual = EvaluateReversePolishNotation.EvalRPN(tokens);
        int expected = 6;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example3()
    {
        string[] tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","-"];
        int actual = EvaluateReversePolishNotation.EvalRPN(tokens);
        int expected = 12;

        Assert.That(actual, Is.EqualTo(expected));
    }
}