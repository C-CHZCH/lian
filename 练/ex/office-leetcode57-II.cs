namespace ex;

public class OfficeLeetcode57Ii
{
    public int[][] FindContinuousSequence(int target)
    {
        IList<int[]> res = new List<int[]>();
        var seq = new LinkedList<int>();

        var sum = 0;
        for (var i = 1; i <= target / 2 + 1; i++)
        {
            sum += i;
            seq.AddLast(i);

            while (seq.Count > 0 && sum > target)
            {
                sum -= seq.First.Value;
                seq.RemoveFirst();
            }

            if (sum == target) res.Add(seq.ToArray());
        }

        return res.ToArray();
    }
}