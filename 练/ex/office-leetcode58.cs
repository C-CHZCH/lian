namespace ex;

public class OfficeLeetcode58
{
    public string ReverseWords(string s) {
        string[] temp = s.Split(' ');
        Array.Reverse(temp);
        temp=temp.Where(e => e != "").ToArray();
        string str = string.Join(" ", temp);
        return str;
    }
}