using System;

namespace Solutions.Arrays;

public class CanPlaceFlowersClass
{
        public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        int count=0;
        int len=flowerbed.Length;

        if(n < 0)
            return false;

        if(n == 0)
            return true;
        
        if(len == 1)
        {
            if(flowerbed[0] == 0)
                return 1 == n;
            else 
                return false;
        }

        // Left edge of the flower bed
        if(flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            count++;
            flowerbed[0] = 2;
        }

        // Middle of the flower bed
        for(int i=1; i < len - 2; i++)
        {
            if(flowerbed[i] == 0 && flowerbed[i-1] == 0 && flowerbed[i+1] == 0)
            {
                count++;
                flowerbed[i] = 2;
            }
        }

        // Right edge of flower bed
        if(flowerbed[len - 1] == 0 && flowerbed[len - 2] == 0)
        {
            count++;
            flowerbed[len - 1] = 2;
        }

        return count >= n;
    }

}
