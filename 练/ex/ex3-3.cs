using System;
using System.Collections.Generic;
//1487
namespace ex0303;
public class Solution {
    public string[] GetFolderNames(string[] names) {
        IDictionary<string, int> index = new Dictionary<string, int>();
        int n = names.Length;
        string[] res = new string[n];
        for (int i = 0; i < n; i++) {
            string name = names[i];
            if (!index.ContainsKey(name)) {
                res[i] = name;
                index.Add(name, 1);
            } else {
                int k = index[name];
                while (index.ContainsKey(AddSuffix(name, k))) {
                    k++;
                }
                res[i] = AddSuffix(name, k);
                index[name] = k + 1;
                index.Add(AddSuffix(name, k), 1);
            }
        }
        return res;
    }

    public string AddSuffix(string name, int k) {
        return name + "(" + k + ")";
    }
}