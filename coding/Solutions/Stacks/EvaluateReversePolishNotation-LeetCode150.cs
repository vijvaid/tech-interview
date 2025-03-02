namespace Solutions.Stacks;

public class EvaluateReversePolishNotation
{
    public static int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(var token in tokens)
        {
            if(Int32.TryParse(token, out int number))
            {
                stack.Push(number);
                continue;
            }

            var num2 = stack.Pop();
            var num1 = stack.Pop();
            var answer = 0;
            switch(token)
            {
                case "+":  answer = num1 + num2; break;
                case "-":  answer = num1 - num2;break;
                case "*":  answer = num1 * num2;break;
                case "/":  answer = num1 / num2;break;
            }

            stack.Push(answer);

        }
        
        return stack.Pop();
    }
}