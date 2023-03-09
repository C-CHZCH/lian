using System;

namespace ex;

public class Solution_office06
{

    public int[] ReversePrint(ListNode head)
    {
        List<int>res = new List<int>();
        ListNode idx = head;
        while (idx.next != null)
        {
            res.Add(idx.val);
            idx = idx.next;
        }

        res.Reverse();
        return res.ToArray();
    }
}



  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
