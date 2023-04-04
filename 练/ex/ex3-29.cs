namespace ex;

/*
给你一个整数 n，请返回长度为 n 、仅由元音 (a, e, i, o, u) 组成且按 字典序排列 的字符串数量。

字符串 s 按 字典序排列 需要满足：对于所有有效的 i，s[i] 在字母表中的位置总是与 s[i+1] 相同或在 s[i+1] 之前。*/

public class Ex329
{
    public int CountVowelStrings(int n)
    {
        //DP简单迭代

        #region DP

        var dp = new int[5];
        Array.Fill(dp, 1);
        for (var i = 1; i < n; i++)
        for (var j = 1; j < 5; j++)
            dp[j] += dp[j - 1];
        return dp.Sum();

        #endregion

        //相当于是把n个字符放入5个代表元音的盒子中，且允许空盒。其实顺序是确定的，最终的结果样式取决于“隔板”放的位置
        //因为可以空盒，因此隔板可以放置于n以外的位置
        //在n个元素间插入（b-1）个板，即把n个元素分成b组，这里的b为5。因为允许空盒，因此可以等价于把n+5个字符放入5个盒子中，每个盒子至少一个字符
        //即C(n+4,4)

        #region Math

        return (n + 4) * (n + 3) * (n + 2) * (n + 1) / (4 * 3 * 2 * 1);

        #endregion
    }
}