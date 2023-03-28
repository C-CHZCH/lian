namespace ex;

public class Ex223
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        IList<bool> res = new List<bool>();
        var n = l.Length;
        for (var i = 0; i < n; i++)
        {
            var lIndex = l[i];
            var rIndex = r[i];
            var dl = -1;
            var depend = true;
            var isequal = false;
            for (var j = lIndex + 1; j <= rIndex; j++)
            {
                if (isequal && nums[j] == nums[j - 1]) continue;
                if (nums[j] == nums[j - 1] && dl == -1)
                {
                    isequal = true;
                    continue;
                }

                if (dl != -1 && nums[j] == nums[j - 1])
                {
                    res.Add(false);
                    depend = false;
                    break;
                }

                if (dl == -1) dl = Math.Abs(nums[j] - nums[j - 1]);
                if (dl != Math.Abs(nums[j] - nums[j - 1]))
                {
                    depend = false;
                    break;
                }
            }

            if (depend) res.Add(true);
        }

        return res;
    }
}