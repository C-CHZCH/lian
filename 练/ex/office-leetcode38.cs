using System.Text;

namespace ex;

public class SolutionOffice38
{
    private IList<string> rec;
    private bool[] vis;

    public string[] Permutation(string s)
    {
        var n = s.Length;
        rec = new List<string>();
        vis = new bool[n];
        var arr = s.ToCharArray();
        Array.Sort(arr);
        var perm = new StringBuilder();
        Backtrack(arr, 0, n, perm);
        var size = rec.Count;
        var recArr = new string[size];
        for (var i = 0; i < size; i++) recArr[i] = rec[i];
        return recArr;
    }

    public void Backtrack(char[] arr, int i, int n, StringBuilder perm)
    {
        if (i == n)
        {
            rec.Add(perm.ToString());
            return;
        }

        for (var j = 0; j < n; j++)
        {
            if (vis[j] || (j > 0 && !vis[j - 1] && arr[j - 1] == arr[j])) continue; //重复或者已经使用过则可以直接跳过
            vis[j] = true;
            perm.Append(arr[j]);
            Backtrack(arr, i + 1, n, perm);
            perm.Length--;
            vis[j] = false;
        }
    }
}