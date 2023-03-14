namespace ex;

//一个长度为n-1的递增排序数组中的所有数字都是唯一的，并且每个数字都在范围0～n-1之内。在范围0～n-1内的n个数字中有且只有一个数字不在该数组中，请找出这个数字。
public class OfficeLeetcode53Ii
{
    public int MissingNumber(int[] nums)
    {
        //注意奇数长度的nums以及偶数长度的nums的mid对于r和l的判断不同
        var ans = -1;
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (mid == nums[mid])
            {
                left = mid + 1;
            }
            else
            {
                ans = mid;
                right = mid - 1;
            }
        }

        return ans == -1 ? nums.Length : ans;
    }
}