namespace Solutions.Stacks;

public class MinStack
{
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if( minStack.Count == 0)
            minStack.Push(val);
        else
        {
            int currentMin = minStack.Peek();
            minStack.Push( val < currentMin ? val : currentMin);
        }
        stack.Push(val);
    }
    
    public void Pop() {
        minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        if(stack.Count > 0) 
            return stack.Peek();
        return 0;
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}