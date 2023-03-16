namespace ex;

public class OfficeLeetcode33
{
    public bool VerifyPostorder(int[] postorder)
    {
        var n = postorder.Length;
        return VerifyPostorderInternal(postorder, 0, n - 1);
    }

    private bool VerifyPostorderInternal(int[] postorder, int lo, int hi)
    {
        //原理就是根据二叉搜索的特性，先找到以当前“最右”节点为根节点下的右子树的开始。
        if (lo >= hi) return true;
        var rootval = postorder[hi];
        var rightStart = hi;
        for (var i = lo; i < hi; i++)//假如在这个查找循环中找到了不符合二叉搜索树特性的话直接返回false。
            if (postorder[i] > rootval)//
            {
                if (rightStart == hi) rightStart = i;
            }
            else if (rightStart != hi)
            {
                return false;
            }

        var l = VerifyPostorderInternal(postorder, lo, rightStart - 1);
        var r = VerifyPostorderInternal(postorder, rightStart, hi - 1);
        return l & r;
    }
}