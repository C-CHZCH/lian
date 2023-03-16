namespace ex;

public class Ex315
{
    public int MaximalNetworkRank(int n, int[][] roads)
    {
        var isConnect = new bool[n][];
        for (var i = 0; i < n; i++) isConnect[i] = new bool[n];

        var num = new int[n];
        foreach (var road in roads)
        {
            isConnect[road[0]][road[1]] = true;
            isConnect[road[1]][road[0]] = true;
            num[road[0]]++;
            num[road[1]]++;
        }


        var ans = 0;
        for (var i = 0; i < n; i++)
        for (var j = i + 1; j < n; j++)
        {
            var rank = num[i] + num[j] - (isConnect[i][j] ? 1 : 0);
            ans = Math.Max(ans, rank);
        }

        return ans;
    }
}