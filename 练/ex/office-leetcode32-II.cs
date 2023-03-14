namespace ex;

public class SolutionOffice32Ii
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count() != 0)
        {
            var size = queue.Count();
            IList<int> list = new List<int>();
            for (var i = 0; i < size; i++)
            {
                var t = queue.Dequeue();
                list.Add(t.val);
                if (t.left != null) queue.Enqueue(t.left);

                if (t.right != null) queue.Enqueue(t.right);
            }

            res.Add(list);
        }

        /*for (int i = 1; i <= res.Count(); i++)
        {
            if (i % 2 == 0)
            {
                res[i - 1] = res[i - 1].Reverse().ToList();
            }
        }*/
        return res;
    }
}