namespace ex.officeSpecial;

public class Office004
{
    public int SingleNumber(int[] nums)
    {
        var arr = new int[32];
        foreach (var num in nums)
            for (var i = 0; i < 32; i++)
                arr[i] += (num >> (31 - i)) & 1;

        var res = 0;
        for (var i = 0; i < 32; i++) res = (res << 1) + arr[i] % 3;

        return res;
    }
}