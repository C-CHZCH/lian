namespace ex;

public class SolutionOffice50
{
    public char FirstUniqChar(string s)
    {
        if (s == null) return ' ';
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
            if (!dict.TryAdd(c, 1))
                dict[c]++;

        for (var i = 0; i < s.Length; i++)
            if (dict[s[i]] == 1)
                return s[i];

        return s[0];
    }
}