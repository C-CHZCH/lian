namespace ex;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int x)
    {
        val = x;
    }

    public TreeNode(int x, TreeNode y, TreeNode z)
    {
        val = x;
        left = y;
        right = z;
    }
}

//判断B是否为A子树
internal class SolutionOffice26
{
    public bool IsSubStructure(TreeNode A, TreeNode B)
    {
        if (A == null || B == null) return false;
        return DFS(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B);
    }

    private bool DFS(TreeNode A, TreeNode B)
    {
        if (B == null) return true; //必须先校验Node B是否为null，若已成功dfs至null，说明B已被遍历完毕
        if (A == null) return false;


        return A.val == B.val && DFS(A.left, B.left) && DFS(A.right, B.right);
    }
}