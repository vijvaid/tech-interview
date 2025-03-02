using NUnit.Framework;
using Solutions.Stacks;

namespace Solutions.Tests.Stacks;

public class ValidParenthesesTests
{
    [Test]
    public void Example1()
    {
        string s = "()";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example2()
    {
        string s = "()[]{}";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Example3()
    {
        string s = "(]";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void EmptyString()
    {
        string s = "";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void OnlyOpenParentheses()
    {
        string s = "(((";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void OnlyCloseParentheses()
    {
        string s = ")))";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MismatchedParentheses()
    {
        string s = "([)]";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void NestedParentheses()
    {
        string s = "((()))";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void NestedAndMixedParentheses()
    {
        string s = "{[()]}";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void UnbalancedNestedParentheses()
    {
        string s = "{[()]";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void UnbalancedNestedParentheses2()
    {
        string s = "[(])";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void LargeString()
    {
        string s = "(){}[][[()]](){}[][[()]](){}[][[()]](){}[][[()]](){}[][[()]]";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
        [Test]
    public void SingleOpenBracket()
    {
        string s = "(";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
        [Test]
    public void SingleClosedBracket()
    {
        string s = ")";
        bool expected = false;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void ComplexMix()
    {
        string s = "(([]){})";
        bool expected = true;
        bool actual = ValidParentheses.IsValid(s);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
