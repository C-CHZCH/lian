namespace ex;

public class SolutionOffice29
{
    public int[] SpiralOrder(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) return new int[0];
        int m = matrix.Length, n = matrix[0].Length;
        var total = m * n;
        var order = new int[total];
        var index = 0;
        int top = 0, bottom = m - 1, left = 0, right = n - 1;
        while (index < total)
        {
            for (var col = left; col <= right && index < total; col++)
            {
                order[index] = matrix[top][col];
                index++;
            }

            top++;
            for (var row = top; row <= bottom && index < total; row++)
            {
                order[index] = matrix[row][right];
                index++;
            }

            right--;
            for (var col = right; col >= left && index < total; col--)
            {
                order[index] = matrix[bottom][col];
                index++;
            }

            bottom--;
            for (var row = bottom; row >= top && index < total; row--)
            {
                order[index] = matrix[row][left];
                index++;
            }

            left++;
        }

        return order;
    }
}