namespace ex;

public class OfficeLeetcode64
{
    public int SumNums(int n)
    {
        return n == 0 ? 0 : n + SumNums(n - 1);
    }
}