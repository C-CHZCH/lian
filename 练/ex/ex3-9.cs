namespace ex0309;

public class Solution
{
    public int MinimumRecolors(string blocks, int k)
    {
        int l = 0, r = 0, cnt = 0;
        while (r < k)
        {
            cnt += blocks[r] == 'W' ? 1 : 0;
            r++;
        }

        var res = cnt;
        while (r < blocks.Length)
        {
            cnt += blocks[r] == 'W' ? 1 : 0;
            cnt -= blocks[l] == 'W' ? 1 : 0; //往后移动了，那么假如l处为白色，这个涂白的操作就不需要了，因此需要减一
            res = Math.Min(res, cnt);
            l++;
            r++;
        }

        return res;
    }
}