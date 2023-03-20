namespace ex;

public class SolutionOffice35
{
    private readonly Dictionary<Node, Node> cachedNode = new();

    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;
        if (!cachedNode.ContainsKey(head))
        {
            var headNew = new Node(head.val);
            cachedNode.Add(head, headNew);
            headNew.next = CopyRandomList(head.next);
            headNew.random = CopyRandomList(head.random);
        }

        return cachedNode[head];
    }

    public class Node
    {
        public Node next;
        public Node random;
        public int val;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}