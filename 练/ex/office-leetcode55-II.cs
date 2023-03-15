namespace ex;

public class OfficeLeetcode55Ii
{
    public bool IsBalanced(TreeNode root)
    {
        if (Find(root, 1) == -1) return false;
        return true;
    }

    private int Find(TreeNode root, int count)
    {
        if (root == null) return count;
        ++count;
        var left = Find(root.left, count);
        var right = Find(root.right, count);
        if (left == -1 || right == -1) return -1;
        if (Math.Abs(left - right) > 1) return -1;
        return Math.Max(left, right);
    }
}