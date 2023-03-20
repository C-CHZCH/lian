namespace ex;

public class OfficeLeetcode14Ii
{
    public int CuttingRope(int n)
    {
        if (n == 2) return 1;
        if (n == 3) return 2;
        long res = 1;
        while (n > 4)
        {
            res *= 3;
            res %= 1000000007;
            n -= 3;
        }

        res *= n;
        return (int)(res % 1000000007);
    }
}