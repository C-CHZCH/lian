namespace ex;

public class Ex314
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        var res = new int[rowSum.Length][];
        for (var i = 0; i < rowSum.Length; i++) res[i] = new int[colSum.Length];

        int IndexRow = 0, IndexCol = 0;

        while (IndexRow < rowSum.Length && IndexCol < colSum.Length)
        {
            var val = Math.Min(rowSum[IndexRow], colSum[IndexCol]);
            res[IndexRow][IndexCol] = val;
            rowSum[IndexRow] -= val;
            colSum[IndexCol] -= val;
            if (rowSum[IndexRow] == 0) IndexRow++;
            if (colSum[IndexCol] == 0) IndexCol++;
        }

        return res;
    }
}