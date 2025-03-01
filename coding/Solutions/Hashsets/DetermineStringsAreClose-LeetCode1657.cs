namespace Solutions.Hashsets;

public class DetermineStringsAreClose
{
    private Dictionary<char,int> BuildDictionary(string word)
    {
        var dict = new Dictionary<char, int>();
        foreach(char c in word)
        {
            if(dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        return dict;
    }

    public bool CloseStrings(string word1, string word2)
    {
        if(word1.Length != word2.Length)
        {
            return false;
        }

        var dict1 = BuildDictionary(word1);
        var dict2 = BuildDictionary(word2);

        // Item counts of dictionary should be same
        if(dict1.Keys.Count() != dict2.Keys.Count())
        {
            return false;
        }

        // Keys should be same
        var keys1 = dict1.Keys.ToList();
        var keys2 = dict2.Keys.ToList();
        keys1.Sort();
        keys2.Sort();

        if(!keys1.SequenceEqual(keys2))
        {
            return false;
        }

        // Values should be same (item counts so we can swap later to make it close)
        var values1 = dict1.Values.ToList();
        var values2 = dict2.Values.ToList();
        values1.Sort();
        values2.Sort();

        if(!values1.SequenceEqual(values2))
        {
            return false;
        }

        return true;
     }
}