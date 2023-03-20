namespace ex;

public class CQueue
{
    private readonly Stack<int> _post = new();
    private readonly Stack<int> _pre = new();

    public void AppendTail(int value)
    {
        _pre.Push(value);
    }

    public int DeleteHead()
    {
        if (_post.Count == 0)
            while (_pre.Count != 0)
                _post.Push(_pre.Pop());
        if (_post.Count == 0) return -1;

        var deleteItem = _post.Pop();
        return deleteItem;
    }
}