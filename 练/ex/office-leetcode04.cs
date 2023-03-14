namespace ex;

internal class SolutionOffice04
{
    public bool FindNumberIn2DArray(int[][] matrix, int target)
    {
        var m = matrix.Length;
        if (m == 0) return false;
        var n = matrix[0].Length;
        int x = 0, y = n - 1;
        while (x < m && y >= 0)
        {
            if (matrix[x][y] == target) return true;
            if (matrix[x][y] > target)
                --y;
            else
                ++x;
        }

        return false;
    }
}