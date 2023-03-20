namespace ex;

public class SolutionOffice06
{
    public int[] ReversePrint(ListNode head)
    {
        var res = new List<int>();
        var idx = head;
        while (idx.next != null)
        {
            res.Add(idx.val);
            idx = idx.next;
        }

        res.Reverse();
        return res.ToArray();
    }
}

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int x)
    {
        val = x;
    }
}