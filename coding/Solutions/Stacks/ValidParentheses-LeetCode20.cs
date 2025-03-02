namespace Solutions.Stacks;

public class ValidParentheses
{
    public static bool IsValid(string s)
    {   
        Stack<char> stack = new();
        Dictionary<char, char> mapping = new Dictionary<char, char>{ 
            { ')', '(' } ,
            { ']', '[' },
            { '}', '{' }
        };

        foreach(char c in s)
        {
            if( mapping.ContainsKey(c))
            {
                if(stack.Count == 0 || stack.Pop() != mapping[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}