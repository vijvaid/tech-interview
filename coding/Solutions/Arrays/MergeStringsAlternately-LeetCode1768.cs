
using System.Text;

namespace Solutions.Arrays;

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2) {
        
        var len1 = word1.Length;
        var len2 = word2.Length;

        var output = new StringBuilder();

        var i=0;
        var j=0;

        while(true)
        {
            if(i < len1)
            {
                output.Append(word1[i]);
                i++;
            } 

            if(j < len2)
            {
                output.Append(word2[j]);
                j++;
            }

            if( i >= len1 && j >= len2) break;

        }

        return output.ToString();
    }
}
