//1590

namespace ex;

internal class Ex310
{
    public int MinSubarray(long[] nums, int p)
    {
        var sum = nums.Sum();
        var reset = sum % p; //还差多少，也就是我们至少要削减的子数组的数组和
        if (reset == 0) return 0;
        var dict = new Dictionary<long, int>();
        dict[0] = 0;
        sum = 0;
        var res = nums.Length;
        for (var i = 1; i <= nums.Length; i++)
        {
            sum += nums[i - 1];
            var t = (sum - reset + p) % p; //比这个削减值多多少(比reset小的不会进入这个if的)
            if (dict.ContainsKey(t)) //如果存在这么一个前缀数组刚好等于这个多出来的值
                res = Math.Min(res, i - dict[t]); //那么夹在当前i以及这个前缀数组之间的子数组就是我们要的

            dict[sum % p] = i; //保存前缀数组长，至于这里为什么要取余，是因为我们一直往下迭代的时候我们需要保证我们在if中得到的目标子数组的长度是最小的
        }

        if (res == nums.Length) return -1;
        return res;
    }
}