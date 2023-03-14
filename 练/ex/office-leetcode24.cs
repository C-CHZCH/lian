namespace ex;

internal class SolutionOffice24
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode pre = null, cur = head, next = null;
        while (cur != null)
        {
            next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }

        return pre;
    }
}