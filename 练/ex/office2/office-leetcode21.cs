namespace ex;

internal class SolutionOffice21
{
    public int[] Exchange(int[] nums)
    {
        // LinkedList<int>res = new LinkedList<int>();
        // int len = nums.Length;
        // for (int i = 0; i < len; i++)
        // {
        //     if (nums[i] % 2 == 0) res.AddLast(nums[i]);
        //     else res.AddFirst(nums[i]);
        // }
        // return res.ToArray();

        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            while (left < right && (nums[left] & 1) == 1) left++;
            while (right > left && (nums[right] & 1) == 0) right--;
            if (left < right) Swap(ref nums, left++, right--);
        }

        return nums;
    }

    private void Swap(ref int[] nums, int left, int right)
    {
        var t = nums[left];
        nums[left] = nums[right];
        nums[right] = t;
    }
}