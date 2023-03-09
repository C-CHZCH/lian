using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class Solution_office18
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head == null) return null;
            if (head.val == val) return head.next;
            var cur = head;
            while (cur != null && cur.next != null)
            {
                if (cur.next.val == val)
                {
                    cur.next = cur.next.next;
                    break;
                }

                cur = cur.next;
            }

            return head;
        }
    }
}
