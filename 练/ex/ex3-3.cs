//1487

namespace ex0303;

public class Solution
{
    public string[] GetFolderNames(string[] names)
    {
        IDictionary<string, int> index = new Dictionary<string, int>();
        var n = names.Length;
        var res = new string[n];
        for (var i = 0; i < n; i++)
        {
            var name = names[i];
            if (!index.ContainsKey(name))
            {
                res[i] = name;
                index.Add(name, 1);
            }
            else
            {
                var k = index[name];
                while (index.ContainsKey(AddSuffix(name, k))) k++;
                res[i] = AddSuffix(name, k);
                index[name] = k + 1;
                index.Add(AddSuffix(name, k), 1);
            }
        }

        return res;
    }

    public string AddSuffix(string name, int k)
    {
        return name + "(" + k + ")";
    }
}