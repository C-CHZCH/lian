namespace ex;

public class OfficeLeetcode66
{
    public int[] ConstructArr(int[] a)
    {
        var ans = new int[a.Length];
        for (int i = 0, num = 1; i < a.Length; num *= a[i], i++) ans[i] = num;

        for (int i = a.Length - 1, num = 1; i >= 0; num *= a[i], i--) ans[i] *= num;

        return ans;
    }
}