namespace ex;

//写一个函数，求两个整数之和，要求在函数体内不得使用 “+”、“-”、“*”、“/” 四则运算符号。
public class OfficeLeetcode65
{
    //涉及没有接触过的位运算计算，其实简化下来，这个while其实是计算b的每一位与a的每一位的加法，每次左移然后与a与都是来计算进位的
    public int Add(int a, int b)
    {
        while (b != 0)
        {
            var carry = (a & b) << 1;
            a = a ^ b;
            b = carry;
        }

        return a;
    }
}