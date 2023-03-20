namespace ex;

public class OfficeLeetcode34
{
    private readonly IList<int> path = new List<int>();
    private readonly IList<IList<int>> paths = new List<IList<int>>();

    public IList<IList<int>> PathSum(TreeNode root, int target)
    {
        DFS(root, target);
        return paths;
    }

    public void DFS(TreeNode node, int target)
    {
        if (node == null) return;
        path.Add(node.val);
        target -= node.val;
        if (node.left == null && node.right == null && target == 0) paths.Add(new List<int>(path));
        DFS(node.left, target);
        DFS(node.right, target);
        path.RemoveAt(path.Count - 1);
    }
}