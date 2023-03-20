namespace ex;

public class SolutionOffice36
{
    private List<Node> nodes;

    public Node TreeToDoublyList(Node root)
    {
        if (root == null) return null;
        nodes = new List<Node>();
        Help(root);
        if (nodes.Count() == 1)
        {
            nodes[0].right = nodes[0];
            nodes[0].left = nodes[0];
            return nodes[0];
        }

        nodes[0].right = nodes[1];
        nodes[0].left = nodes[nodes.Count() - 1];
        for (var i = 1; i < nodes.Count() - 1; i++)
        {
            nodes[i].right = nodes[i + 1];
            nodes[i].left = nodes[i - 1];
        }

        nodes[nodes.Count() - 1].left = nodes[nodes.Count() - 2];
        nodes[nodes.Count() - 1].right = nodes[0];
        return nodes[0];
    }

    private void Help(Node root)
    {
        if (root == null) return;
        if (root.left != null) Help(root.left);
        nodes.Add(root);
        if (root.right != null) Help(root.right);
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int val;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }

        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}