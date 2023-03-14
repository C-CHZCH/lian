using System.Text;

namespace ex;

public class SolutionOffice17
{
    public int[] PrintNumbers(int n)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < n; i++) sb.Append(9);

        var theMax = int.Parse(sb.ToString());
        var res = new int[theMax];
        for (var i = 1; i <= theMax; i++) res[i] = i;
        return res;
    }
}