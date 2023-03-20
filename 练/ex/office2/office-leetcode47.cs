namespace ex;

public class SolutionOffice47
{
    public int MaxValue(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var dp = new int[m + 1, n + 1];
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + grid[i - 1][j - 1];
        return dp[m, n];
    }
}