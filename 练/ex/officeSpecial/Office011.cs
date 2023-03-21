namespace ex.officeSpecial;

public class Office011
{
    public int FindMaxLength(int[] nums)
    {
        var maxLength = 0;
        var dictionary = new Dictionary<int, int>();
        var counter = 0; //counter正代表1多，conuter负则代表0多
        dictionary.Add(counter, -1);
        var n = nums.Length;
        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            if (num == 1)
                counter++;
            else
                counter--;

            if (dictionary.ContainsKey(counter)) //查看前面是否有可以割去的子数组
            {
                var prevIndex = dictionary[counter];
                maxLength = Math.Max(maxLength, i - prevIndex);
            }
            else
            {
                dictionary.Add(counter, i);
            }
        }

        return maxLength;
    }
}