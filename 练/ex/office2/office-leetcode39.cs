namespace ex;

public class SolutionOffice39
{
    public int MajorityElement(int[] nums)
    {
        var time = 0;
        var res = nums[0];
        foreach (var num in nums)
        {
            if (time == 0)
            {
                time = 1;
                res = num;
                continue;
            }

            if (res == num)
            {
                time++;
                continue;
            }

            time--;
        }

        return res;
    }
}