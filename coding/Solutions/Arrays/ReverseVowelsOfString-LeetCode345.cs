using System;

namespace Solutions.Arrays;

public class ReverseVowelsOfString
{

    public static bool IsVowel(char c)
    {
        if(c == 'a' || c == 'e' ||c == 'i' ||c == 'o' ||c == 'u' ||
           c == 'A' || c == 'E' ||c == 'I' ||c == 'O' ||c == 'U')
        {
            return true;
        }

        return false;
    }
    public string ReverseVowels(string s) {
        
        char[] arr = s.ToCharArray();
        
        int len = arr.Length;
 
        int i =0;
        int j = len -1;

        bool lhsFound = false;
        bool rhsFound = false;


        while(i < j )
        {
            if(lhsFound == true && rhsFound == true)
            {
                char temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;

                i++; 
                j--;

                lhsFound = false; 
                rhsFound = false;

                continue;
            }

            if(IsVowel(arr[i]) == true)
              lhsFound = true; 
            else 
                i++;
            
            if(IsVowel(arr[j]) == true)  
                rhsFound = true; 
            else 
                j--;
            
        }

        return string.Concat(arr);
    }


}
