namespace ex;
//给定一棵二叉搜索树，请找出其中第 k 大的节点的值。
public class OfficeLeetcode54
{
    private int ans, count;

    public int kthLargest(TreeNode root, int k)
    {
        helper(root, k);
        return ans;
    }

    private void helper(TreeNode root, int k)
    {
        if (root.right != null) helper(root.right, k);//先找到最大的位置，然后回溯，记录count（对二叉搜索树的理解）
        if (++count == k)
        {
            ans = root.val;
            return;
        }

        if (root.left != null) helper(root.left, k);
    }
}