namespace ex;

public class OfficeLeetcode58
{
    public string ReverseWords(string s)
    {
        var temp = s.Split(' ');
        Array.Reverse(temp);
        temp = temp.Where(e => e != "").ToArray();
        var str = string.Join(" ", temp);
        return str;
    }
}