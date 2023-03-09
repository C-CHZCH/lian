namespace ex;

internal class Solution_office16
{
    public double MyPow(double x, int n)
    {
        if (x == 0) return 0;

        if (n == 0) return 1;

        var power = MyPow(x, n / 2);
        if (n % 2 == 0) return power * power;

        return n > 0 ? power * power * x : power * power / x;
    }
}