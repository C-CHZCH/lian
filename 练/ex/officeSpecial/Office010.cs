namespace ex.officeSpecial;

public class Office010
{
    //前缀和加字典优化
    public int SubarraySum(int[] nums, int k)
    {
        var subarrays = 0;
        IDictionary<int, int> counts = new Dictionary<int, int>();
        counts.Add(0, 1);
        var sum = 0;
        var length = nums.Length;
        for (var i = 0; i < length; i++)
        {
            sum += nums[i];
            //查看在此之前是否有一个子数组和为sum - k，倒是有点像dp了
            var count = counts.ContainsKey(sum - k) ? counts[sum - k] : 0;
            subarrays += count;
            counts.TryAdd(sum, 0);
            counts[sum]++;
        }

        return subarrays;
    }
}