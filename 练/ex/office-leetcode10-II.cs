namespace ex;

public class SolutionOffice10
{
    public int NumWays(int n)
    {
        var dp = new int[2];
        dp[0] = 1;
        dp[1] = 1;
        var res = 1;
        for (var i = 2; i <= n; i++)
        {
            res = (dp[0] + dp[1]) % 1000000007;
            Console.WriteLine(res);
            dp[0] = dp[1];
            dp[1] = res;
        }

        return res;
    }
}