using System;

namespace Solutions.Arrays;

public class StringCompression
{
        public int Compress(char[] chars) {
        int index = 0;

        for(int start =0; start < chars.Length; start++)
        {
            int end = start + 1;
            int count = 1;
            while(end < chars.Length && chars[start] == chars[end])
            {
                end++;
                count++;
            }
            
            chars[index] = chars[start];
            index++;

            if(count > 1)
            {
                string countString = count.ToString();
                foreach(char c in countString)
                {
                    chars[index] = c;
                    index++;
                }
            }

            start = start + count - 1;
        }

        return index;
    }

}
