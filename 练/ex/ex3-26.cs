namespace ex;

public class Ex26
{
    public bool FindSubarrays(int[] nums)
    {
        var n = nums.Length;
        ISet<int> seen = new HashSet<int>();
        for (var i = 0; i < n - 1; ++i)
        {
            var sum = nums[i] + nums[i + 1];
            if (!seen.Add(sum)) return true;
        }

        return false;
    }
}