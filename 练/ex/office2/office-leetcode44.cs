namespace ex;

public class SolutionOffice44
{
    public int FindNthDigit(int n)
    {
        int d = 1, count = 9;
        while (n > (long)d * count)
        {
            n -= d * count;
            d++;
            count *= 10;
        }

        var index = n - 1;
        var start = (int)Math.Pow(10, d - 1);
        var num = start + index / d;
        var digitIndex = index % d;
        var digit = num / (int)Math.Pow(10, d - digitIndex - 1) % 10;
        return digit;
    }
}