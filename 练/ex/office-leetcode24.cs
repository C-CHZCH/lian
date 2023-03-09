using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
     class Solution_office24
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
}
