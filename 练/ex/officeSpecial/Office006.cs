namespace ex.officeSpecial;

public class Office006
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;
        var res = new int[2];
        while (l < r)
        {
            var sum = numbers[l] + numbers[r];
            if (sum == target)
            {
                res = new[] { l, r };
                break;
            }

            if (sum > target)
                --r;
            else
                ++l;
        }

        return res;
    }
}