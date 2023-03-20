namespace ex;

public class SolutionOffice32I
{
    public int[] LevelOrder(TreeNode root)
    {
        if (root == null) return new int[0];
        var res = new List<int>();
        var treeNodes = new Queue<TreeNode>();
        treeNodes.Enqueue(root);
        while (treeNodes.Count() != 0)
        {
            var t = treeNodes.Dequeue();
            res.Add(t.val);
            if (t.left != null) treeNodes.Enqueue(t.left);

            if (t.right != null) treeNodes.Enqueue(t.right);
        }

        return res.ToArray();
    }
}