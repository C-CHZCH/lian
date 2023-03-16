namespace ex;

public class OfficeLeetcode62
{
    public int LastRemaining(int n, int m)
    {
        //迭代：这其实是自底向上的思想。可以这么想，当数组只剩下一个数时，那么被删除的必定是0，那么我们现在以这个位起点来倒退，回到上一层，也就是n = 1的时候，那么被删除的位置则为(0 + m)%n。
        //以此类推
        var remaining = 0;
        for (var i = 2; i <= n; i++) remaining = (remaining + m) % i;
        return remaining;
    }
}