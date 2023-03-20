namespace ex;

public class OfficeLeetcode57
{
    public int[] TwoSum(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        var sum = -1;
        while (l < r)
        {
            sum = nums[l] + nums[r];
            if (sum == target) return new[] { nums[l], nums[r] };
            if (sum > target) r--;
            else l++;
        }

        return new int[] { };
    }
}