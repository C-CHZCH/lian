namespace ex;

internal class SolutionOffice22
{
    public ListNode GetKthFromEnd(ListNode head, int k)
    {
        var fast = head;
        var slow = head;
        for (var i = 0; i < k; i++) fast = fast.next;

        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        return slow;
    }
}