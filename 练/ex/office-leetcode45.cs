using System.Text;

namespace ex;

public class OfficeLeetcode45
{
    public string MinNumber(int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return "";
        var arr = new string[n];
        for (var i = 0; i < n; i++) arr[i] = nums[i].ToString();

        Array.Sort(arr, int(a, b) =>
        {
            string x = a + b, y = b + a;
            for (var i = 0; i < x.Length; i++)
                if (x[i] < y[i]) return -1;
                else if (x[i] > y[i]) return 1;
            return 0;
        });
        var ans = new StringBuilder();
        for (var i = 0; i < n; i++) ans.Append(arr[i]);

        return ans.ToString();
    }
}