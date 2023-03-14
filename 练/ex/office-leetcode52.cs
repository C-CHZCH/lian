namespace ex;

public class OfficeLeetcode52
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;
        var n1 = headA;
        var n2 = headB;

        while (n1 != n2)
        {
            n1 = n1 == null ? headB : n1.next;
            n2 = n2 == null ? headA : n2.next;
        }

        return n1;
    }
}