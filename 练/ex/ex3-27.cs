namespace ex;

//1638
public class Ex327
{
    /**
     * think:
     * 1. 将t的所有子串保存在tree中
     * 2. 遍历s，通过递归的方式计算 相差一个字符的情况
     */
    
    //这个tree的children数组就是拿来保存子串的，count是保存子串的长度
    public int CountSubstrings(string s, string t)
    {
        var root = new TreeNode();

        #region 1. 将t中的所有子串放入tree中
        //这个树 ，root的数组是保存以每一个字符串为头形成的所有子串树的头
        for (var i = 0; i < t.Length; i++)
        {
            var node = root;
            for (var j = i; j < t.Length; j++)
            {
                var curr = t[j] - 'a';
                if (node.Children[curr] == null)
                {
                    node = node.Children[curr] = new TreeNode
                    {
                        Count = 1
                    };
                }
                else
                {
                    node = node.Children[curr];
                    node.Count++;
                }
            }
        }

        #endregion

        var res = 0;

        #region 2.遍历s, 递归计算子串结果

        for (var i = 0; i < s.Length; i++) Help(i, false, root);//根据s中不同子串的开头来作遍历

        #endregion

        return res;

        //辅助统计方法
        // i - 下标！（代表s串）
        // hasDiff - 是否相差一个字符
        // node - 当前节点（代表t串）
        void Help(int i, bool hasDiff, TreeNode node)
        {
            if (hasDiff) // 符合条件，进行求和
                res += node.Count;

            if (i == s.Length) return;

            var curr = s[i] - 'a';

            if (node.Children[curr] == null) // 无法移动（当我们发现子串中查找不到当前的的字符时）
            {
                // 已经改变过字符，则直接结束
                if (hasDiff) return;

                foreach (var item in node.Children) // 遍历可改变的字符
                    if (item != null)
                        Help(i + 1, true, item);
            }
            else
            {
                // 首先先计算不改变的情况
                Help(i + 1, hasDiff, node.Children[curr]);

                if (!hasDiff)
                    for (var j = 0; j < node.Children.Length; j++) // 遍历可改变的字符
                    {
                        // 避免重复计算
                        if (j == curr) continue;

                        var item = node.Children[j];

                        if (item != null) Help(i + 1, true, item);
                    }
            }
        }
    }

    private class TreeNode
    {
        public readonly TreeNode[] Children = new TreeNode[26];//保存子串
        public int Count;//Count代表这相同的子串的数量
    }
}