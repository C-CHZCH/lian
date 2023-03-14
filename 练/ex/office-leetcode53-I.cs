namespace ex;

public class OfficeLeetcode53I
{
    public int Search(int[] nums, int target)
    {
        var leftIdx = BinarySearch(nums, target, true); //找到最接近target的index（左侧）
        var rightIdx = BinarySearch(nums, target, false) - 1; //找到最接近target的index（右侧）
        if (leftIdx <= rightIdx && rightIdx < nums.Length && nums[leftIdx] == target && nums[rightIdx] == target)
            return rightIdx - leftIdx + 1;
        return 0;
    }

    public int BinarySearch(int[] nums, int target, bool lower)
    {
        int left = 0, right = nums.Length - 1, ans = nums.Length;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] > target || (lower && nums[mid] >= target))
            {
                right = mid - 1;
                ans = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return ans;
    }
}