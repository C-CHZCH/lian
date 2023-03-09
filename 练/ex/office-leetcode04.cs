namespace ex;

internal class Solution_office04
{
    public bool FindNumberIn2DArray(int[][] matrix, int target)
    {
        int m = matrix.Length;
        if (m == 0) return false;
        int n = matrix[0].Length;
        int x = 0, y = n - 1;
        while (x < m && y >= 0)
        {
            if (matrix[x][y] == target)
            {
                return true;
            }
            if (matrix[x][y] > target)
            {
                --y;
            }
            else
            {
                ++x;
            }
        }
        return false;
    }
}