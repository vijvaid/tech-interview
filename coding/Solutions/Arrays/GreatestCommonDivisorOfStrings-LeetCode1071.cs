using System;

namespace Solutions.Arrays;

public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2) {

        if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
        {
            // One of the strings is empty
            return string.Empty;
        }

        if( (str1 + str2) != (str2 + str1))
        {
            // concat alternatively and end result should be same.
            return string.Empty;
        }

        int gcd = GCD(str1.Length, str2.Length);

        return str1[..gcd];
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
