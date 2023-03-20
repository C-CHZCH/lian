namespace ex;

public class SolutionOffice48
{
    public int LengthOfLongestSubstring(string s)
    {
        var tong = new int[128];
        var len = s.Length;
        if (len <= 1) return len;
        s = s[0] + s; // 设置一个哨兵节点，避免出现头和尾相同的情况
        len++;
        var left = 0;
        var max = 0;
        for (var i = 0; i < 128; i++) tong[i] = -1;
        for (var i = 0; i < len; i++)
        {
            if (tong[s[i]] >= left) left = tong[s[i]] + 1;
            tong[s[i]] = i;
            var mid = i - left + 1;
            max = max > mid ? max : mid;
        }

        return max;
    }
}