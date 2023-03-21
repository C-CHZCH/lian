namespace ex.officeSpecial;

public class Office012
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0, cur = 0;
        foreach (var i in nums) sum += i;
        for (var i = 0; i < nums.Length; i++)
        {
            sum -= nums[i];
            if (cur == sum) return i;
            cur += nums[i];
        }

        return -1;
    }
}