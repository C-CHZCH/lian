namespace ex.officeSpecial;

public class Office002
{
    //模拟一遍手算二进制加法
    public string AddBinary(string a, string b)
    {
        int len1 = a.Length, len2 = b.Length;
        var len = Math.Max(len1, len2);
        var arr = new char[len];
        var extra = 0; //保存进位
        for (int i = len1 - 1, j = len2 - 1, k = len - 1; k >= 0; k--)
        {
            var num1 = i >= 0 ? a[i--] - '0' : 0;
            var num2 = j >= 0 ? b[j--] - '0' : 0;
            var num = num1 + num2 + extra;
            extra = num / 2;
            num = num % 2;
            arr[k] = (char)(num + '0');
        }

        var ans = new string(arr);
        if (extra > 0) return "1" + ans;
        return ans;
    }
}