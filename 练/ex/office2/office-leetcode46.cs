namespace ex;

public class SolutionOffice46
{
    public int TranslateNum(int num)
    {
        var str = num.ToString();
        var n = str.Length;
        if (n == 1) return 1;
        var dp = new int[n + 1];
        dp[1] = 1;
        dp[0] = 1;
        for (var i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1];
            if (str[i - 2] == '1') dp[i] += dp[i - 2];
            else if (str[i - 2] == '2' && str[i - 1] < '6') dp[i] += dp[i - 2];
        }

        return dp[n]; //打家劫舍
    }
}