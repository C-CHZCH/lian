namespace ex;

public class OfficeLeetcode63
{
    public int MaxProfit(int[] prices)
    {
        //维护一个最小值即可
        if (prices == null || prices.Length <= 1) return 0;
        int res = 0, min = prices[0];
        for (var i = 1; i < prices.Length; i++)
            if (prices[i] <= min)
                min = prices[i];
            else
                res = Math.Max(res, prices[i] - min);
        return res;


        /*//dp：
        for(prices.Length < 2) return 0; // 没有卖出的可能性
        // 定义状态，直到第i天所能获取的最大的卖出收益
        int[] dp = new int[prices.Length];
        dp[0] = 0;  // 初始边界
        int cost = prices[0]; // 成本
        for (int i = 1; i < prices.Length; i++) {
            dp[i] = Math.Max(dp[i - 1], prices[i] - cost);
            // 选择较小的成本买入
            cost = Math.Min(cost, prices[i]);
        }

        return dp[prices.Length - 1];*/
    }
}