namespace ex;

public class SolutionOffice27
{
    public TreeNode MirrorTree(TreeNode root)
    {
        if (root == null) return null;
        return new TreeNode(root.val, MirrorTree(root.right), MirrorTree(root.left));
    }
}