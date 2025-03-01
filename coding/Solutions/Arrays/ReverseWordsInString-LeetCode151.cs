
using System.Text;

namespace Solutions.Arrays;

public class ReverseWordsInString
{
    public string ReverseWords(string s) {
        
        string[] parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var count = parts.Length;
        if(count == 0)
        {
            return string.Empty;
        }
        
        StringBuilder result = new StringBuilder();
        for(int i= count - 1; i > 0; i--)
        {
            result.Append(parts[i] + " ");
        }
        result.Append(parts[0]);

        return result.ToString();
    }

}
