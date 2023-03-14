namespace ex;

public class SolutionOffice15
{
    public int HammingWeight(uint n)
    {
        var ret = 0;
        while (n != 0)
        {
            n &= n - 1;
            ret++;
        }

        return ret;
    }
}