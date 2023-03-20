namespace ex;

public class OfficeLeetcode60
{
    public double[] DicesProbability(int n)
    {
        var dp = new double[6];
        Array.Fill(dp, 1.0 / 6.0);
        for (var i = 2; i <= n; i++)
        {
            var temp = new double[5 * i + 1]; //因为点数和的范围在[n,6]因此，根据等差数列，差值位1来计算的话就有5n+1个数
            for (var k = 0; k < dp.Length; k++)
            for (var j = 0; j < 6; j++)
                temp[k + j] += dp[k] / 6;
            dp = temp;
        }

        return dp;
    }
}