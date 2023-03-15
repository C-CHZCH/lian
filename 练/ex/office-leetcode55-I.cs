namespace ex;

public class OfficeLeetcode55I
{
    private int res;

    public int MaxDepth(TreeNode root)
    {
        DFS(root, 1);
        return res;
    }

    private void DFS(TreeNode root, int count)
    {
        if (root == null)
        {
            res = Math.Max(res, count);
            return;
        }

        DFS(root.left, count + 1);
        DFS(root.right, count + 1);
    }
}