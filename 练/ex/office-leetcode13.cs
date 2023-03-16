namespace ex;

public class OfficeLeetcode13
{
    //深度优先搜索
    public int MovingCount(int m, int n, int k)
    {
        var visited = new bool[m, n];
        return BackTrack(visited, 0, 0, k);
    }

    public int BackTrack(bool[,] visited, int i, int j, int k)
    {
        if (i >= visited.GetLength(0) || j >= visited.GetLength(1) || visited[i, j]) return 0;
        var sum = i / 10 + i % 10 + j / 10 + j % 10;
        if (sum > k) return 0;

        visited[i, j] = true;
        return 1 + BackTrack(visited, i + 1, j, k) + BackTrack(visited, i, j + 1, k);
    }
}