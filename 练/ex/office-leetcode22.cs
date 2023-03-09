using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Solution_office22
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            ListNode fast = head;
            ListNode slow = head;
            for (int i = 0; i < k; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return slow;
        }
    }
}
