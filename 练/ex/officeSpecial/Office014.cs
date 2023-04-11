namespace ex.officeSpecial;

public class Office014
{
    public bool CheckInclusion(string s1, string s2)
    {
        var need = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        foreach (var c in s1.Where(c => !need.TryAdd(c, 1))) need[c]++;

        var left = 0;
        var right = 0;
        var valid = 0;
        while (right < s2.Length)
        {
            // 即将移入窗口的字符		
            var c = s2[right];
            // 右移窗口
            right++;
            if (need.ContainsKey(c))
            {
                if (window.TryGetValue(c, out var value)) value++;
                else window.Add(c, 1);

                if (window[c] == need[c]) valid++;
            }

            // 判断左侧窗口是否要收缩
            while (right - left >= s1.Length)
            {
                // 在这里判断是否已经找到了合法的子串
                if (valid == need.Count) return true;

                var d = s2[left];
                left++;
                // 窗口内数据的一系列更新
                if (!need.ContainsKey(d)) continue;
                if (window[d] == need[d])
                    valid--;
                window[d]--;
            }
        }

        return false;
    }
}