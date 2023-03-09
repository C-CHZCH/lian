namespace ex;

internal class Solution_office14
{
    public int CuttingRope(int n)
    {
        if (n <= 3)

            return n - 1;

        int quotient = n / 3;
        int remainder = n % 3;
        if (remainder == 0)

            return (int)Math.Pow(3, quotient);

        if (remainder == 1)

            return (int)Math.Pow(3, quotient - 1) * 4;

        return (int)Math.Pow(3, quotient) * 2;
    }
}