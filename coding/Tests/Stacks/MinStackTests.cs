using NUnit.Framework;
using Solutions.Stacks;

namespace Solutions.Tests.Stacks;

public class MinStackTests
{
    [Test]
    public void Test1()
    {
        MinStack minStack = new MinStack();
        minStack.Push(-1);
        minStack.Push(0);
        minStack.Push(-3);
        Assert.That(minStack.GetMin(), Is.EqualTo(-3));
        minStack.Pop();
        Assert.That(minStack.Top(), Is.EqualTo(0));
        Assert.That(minStack.GetMin(), Is.EqualTo(-1));
    }

    [Test]
    public void Test2()
    {
        MinStack minStack = new MinStack();
        minStack.Push(2147483646);
        minStack.Push(2147483646);
        minStack.Push(2147483647);
        Assert.That(minStack.Top(), Is.EqualTo(2147483647));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(2147483646));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(2147483646));
        minStack.Pop();
    }
    [Test]
    public void Test3()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        Assert.That(minStack.GetMin(), Is.EqualTo(5));
        Assert.That(minStack.Top(), Is.EqualTo(5));
        minStack.Push(2);
        Assert.That(minStack.GetMin(), Is.EqualTo(2));
        Assert.That(minStack.Top(), Is.EqualTo(2));

        minStack.Push(8);
        Assert.That(minStack.GetMin(), Is.EqualTo(2));
        Assert.That(minStack.Top(), Is.EqualTo(8));

        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(2));
        Assert.That(minStack.Top(), Is.EqualTo(2));
        
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(5));
        Assert.That(minStack.Top(), Is.EqualTo(5));
    }
    
    [Test]
    public void EmptyStack()
    {
        MinStack minStack = new MinStack();
        Assert.That(minStack.Top(), Is.EqualTo(0));
    }

    [Test]
    public void PushAndPopSingleValue()
    {
        MinStack minStack = new MinStack();
        minStack.Push(10);
        Assert.That(minStack.GetMin(), Is.EqualTo(10));
        Assert.That(minStack.Top(), Is.EqualTo(10));
        minStack.Pop();
        Assert.That(minStack.Top(), Is.EqualTo(0));
    }

    [Test]
    public void PushMultipleSameValues()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(5);
        minStack.Push(5);
        Assert.That(minStack.GetMin(), Is.EqualTo(5));
        Assert.That(minStack.Top(), Is.EqualTo(5));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(5));
        Assert.That(minStack.Top(), Is.EqualTo(5));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(5));
        Assert.That(minStack.Top(), Is.EqualTo(5));
        minStack.Pop();
        Assert.That(minStack.Top(), Is.EqualTo(0));

    }
    [Test]
    public void NegativeValues()
    {
        MinStack minStack = new MinStack();
        minStack.Push(-5);
        Assert.That(minStack.GetMin(), Is.EqualTo(-5));
        minStack.Push(-10);
        Assert.That(minStack.GetMin(), Is.EqualTo(-10));
        minStack.Push(-2);
        Assert.That(minStack.GetMin(), Is.EqualTo(-10));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(-10));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(-5));
    }

    [Test]
    public void LargeNumbers()
    {
        MinStack minStack = new MinStack();
        minStack.Push(int.MaxValue);
        minStack.Push(int.MinValue);
        minStack.Push(int.MaxValue);
        Assert.That(minStack.GetMin(), Is.EqualTo(int.MinValue));
        Assert.That(minStack.Top(), Is.EqualTo(int.MaxValue));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(int.MinValue));
        minStack.Pop();
        Assert.That(minStack.GetMin(), Is.EqualTo(int.MaxValue));
    }
}
