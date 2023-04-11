namespace ex;

public class Ex49
{
    public bool CheckDistances(string s, int[] distance)
    {
        return s.Select((c, i) => new { c, i }).GroupBy(a => a.c)
            .All(gp => distance[gp.Key - 'a'] == gp.Last().i - gp.First().i - 1);

        /*Select将字符串s中的每个字符和它的索引组成一个匿名对象，例如’a’和0，'b’和1等。
        GroupBy按照字符分组，得到一个分组序列，每个分组包含相同字符的所有匿名对象。
        All判断分组序列中的每个分组是否满足以下条件：distance数组中该字符对应的值（用字符减去’a’得到索引）->
        等于该分组中最后一个对象的索引减去第一个对象的索引再减一。这个条件就是检查该字符的间距是否正确。
        如果所有分组都满足条件，返回true，否则返回false。*/
    }
}