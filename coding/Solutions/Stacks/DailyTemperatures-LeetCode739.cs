
using System.Diagnostics;

namespace Solutions.Stacks;

public class DailyTemperatures
{
    public static int[] GetDailyTemperatures(int[] temperatures)
    {
        int[] answers = new int[temperatures.Length];
        Stack<int> stack = new();
        stack.Push(0);

        for(int i = 1; i < temperatures.Length; i++)
        {
            int top = stack.Peek();
            while(temperatures[i] > temperatures[top])
            {
                answers[top] = i - top;
                stack.Pop();
                if(stack.Count > 0)
                {
                    top = stack.Peek();
                }
                else
                    break;
            }

            stack.Push(i);

        }

        return answers;
    }
}