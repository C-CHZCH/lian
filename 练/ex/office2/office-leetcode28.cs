namespace ex;

public class SolutionOffice28
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        return Help(root.left, root.right);
    }

    private bool Help(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null) return true;
        if (root1 == null || root2 == null) return false;

        return root1.val == root2.val && Help(root1.left, root2.right) && Help(root1.right, root2.left);
    }
}