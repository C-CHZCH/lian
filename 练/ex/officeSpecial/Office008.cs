namespace ex.officeSpecial;

public class Office008
{
    /*//滑动窗口解法
    public int MinSubArrayLen(int target, int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return 0;

        var ans = int.MaxValue;
        int start = 0, end = 0;
        var sum = 0;
        while (end < n)
        {
            sum += nums[end];
            while (sum >= target)
            {
                ans = Math.Min(ans, end - start + 1);
                sum -= nums[start];
                ++start;
            }

            ++end;
        }

        return ans == int.MaxValue ? 0 : ans;
    }*/

    //前缀和
    private int LowerBound(int[] a, int l, int r, int target)
    {
        int mid = -1, originL = l, originR = r;
        while (l < r)
        {
            mid = (l + r) >> 1;
            if (a[mid] < target) l = mid + 1;
            else r = mid;
        }

        return a[l] >= target ? l : -1;
    }

    public int MinSubArrayLen(int s, int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return 0;

        var ans = int.MaxValue;
        var sums = new int[n + 1];
        // 为了方便计算，令 size = n + 1 
        // sums[0] = 0 意味着前 0 个元素的前缀和为 0
        // sums[1] = A[0] 前 1 个元素的前缀和为 A[0]
        // 以此类推
        for (var i = 1; i <= n; ++i) sums[i] = sums[i - 1] + nums[i - 1];

        for (var i = 1; i <= n; ++i)
        {
            var target = s + sums[i - 1];
            var bound = LowerBound(sums, i, n, target);
            if (bound != -1) ans = Math.Min(ans, bound - i + 1);
        }

        return ans == int.MaxValue ? 0 : ans;
    }
}