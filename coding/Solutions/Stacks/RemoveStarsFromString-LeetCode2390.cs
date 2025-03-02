using System.Text;

namespace Solutions.Stacks;

public class RemoveStarsFromString
{

    public string RemoveStars(string s)
    {
        // Here we are using Stringbuilder as a virtual stack and removing the end char if we encounter a star.
        StringBuilder result = new();

        foreach(char c in s)
        {
            if(c == '*')
            {
                if(result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1);
                }
            }
            else
            {
                result.Append(c);
            }
        }
       
        return result.ToString();
    }
}