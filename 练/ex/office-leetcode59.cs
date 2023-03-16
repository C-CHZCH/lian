namespace ex;

public class OfficeLeetcode59
{
    //我的评价是仔细理解题
    private readonly LinkedList<int> mvq;
    private readonly Queue<int> q;

    public MaxQueue()
    {
        mvq = new LinkedList<int>();
        q = new Queue<int>();
    }

    public int Max_value()
    {
        if (mvq.Count == 0) return -1;
        return mvq.First.Value;
    }

    public void Push_back(int value)
    {
        q.Enqueue(value);
        while (mvq.Count > 0 && mvq.Last.Value < value) mvq.RemoveLast();
        mvq.AddLast(value);
    }

    public int Pop_front()
    {
        if (q.Count == 0) return -1;
        var v = q.Dequeue();
        if (mvq.First.Value == v) mvq.RemoveFirst();
        return v;
    }
}