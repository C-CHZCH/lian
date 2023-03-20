namespace ex.officeSpecial;

public class Office005
{
    //思路新奇
    public int MaxProduct(string[] words)
    {
        var len = words.Length;
        var nums = new int [len];
        // 用一个 int 数字统计每个字符串里面 abcd26  个字符出现的位置 a 用 0代替 b 用 1 
        // 则 abc 可以表示为 111 def 可以表示为 111000 如果不包含重复字符的字符串转换二进制后做与运算肯定为 0
        for (var i = 0; i < len; i++)
        for (var j = 0; j < words[i].Length; j++) //计算查看每一位是否为1
            nums[i] |= 1 << (words[i][j] - 'a');
        var res = 0;
        for (var i = 0; i < len - 1; i++)
        for (var j = i + 1; j < len; j++)
            // 如果两个字符串不包含相同元素 那么与运算肯定为 0
            if ((nums[i] & nums[j]) == 0)
                res = Math.Max(res, words[i].Length * words[j].Length);
        return res;
    }
}