namespace ConsoleApp1;
public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        List<IList<int>> res = new List<IList<int>>();
        res[0][0] = items1[0][0];
        foreach (var val1 in items1)
        {
            bool isfind = false;
            for (int i = 0; i < res.Count(); i++)
            {
                if (res[i][0] == val1[0])
                {
                    isfind = true;
                }
            }

            if (!isfind)
            {
                res.Add(new List<int>(val1));
            }
        }
        foreach (var val2 in items2)
        {
            bool isfind = false;
            for (int i = 0; i < res.Count(); i++)
            {
                if (res[i][0] == val2[0])
                {
                    isfind = true;
                }
            }

            if (!isfind)
            {
                res.Add(new List<int>(val2));
            }
        }

        return res;
    }
}