namespace ex.officeSpecial;

public class Office007
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1, k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[j] + nums[k];
                if (sum == -nums[i])
                {
                    res.Add(new List<int> { nums[i], nums[j], nums[k] });
                    while (j < k && nums[j] == nums[j + 1]) j++; //跳过右侧所有相等的数
                    j++;
                    while (j < k && nums[k] == nums[k - 1]) k--; //跳过左侧所有相等的数
                    k--;
                }
                else if (sum > -nums[i])
                {
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }

        return res;
    }
}