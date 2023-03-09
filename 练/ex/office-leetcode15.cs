namespace ex;

public class Solution_office15
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