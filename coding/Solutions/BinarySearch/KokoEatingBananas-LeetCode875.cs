namespace Solutions.BinarySearch;

public class KokoEatingBananas
{
    private static bool IsValidCase(int[] piles, int h, int value)
    {
        long hours = 0;
        foreach (var pile in piles)
        {
            if (value >= pile)
                hours += 1;
            else
                hours += (long)Math.Ceiling((double)pile / value);
        }

        return hours <= h;
    }

    public static int MinEatingSpeed(int[] piles, int h)
    {
        int min = 1;
        int max = piles.Max();
        int speed = -1;

        while (min <= max)
        {
            int mid = (int)(max + min) / 2;
            if (IsValidCase(piles, h, mid))
            {
                speed = mid;
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return speed;
    }
}
