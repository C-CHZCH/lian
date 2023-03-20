namespace ex;

public class SolutionOffice30
{
    //API:
    /*public class MinStack
    {
        private LinkedList<int> _linkedList;

        /** initialize your data structure here. #1#
        public MinStack()
        {
            _linkedList = new LinkedList<int>();
        }
    
        public void Push(int x)
        {
            _linkedList.AddLast(x);
        }
    
        public void Pop() {
            _linkedList.RemoveLast();
        }
    
        public int Top()
        {
            return _linkedList.Last();
        }
    
        public int Min()
        {
            return _linkedList.Min();
        }
    }*/

    public class MinStack
    {
        private readonly Stack<int> data;
        private readonly Stack<int> getMin;

        public MinStack()
        {
            data = new Stack<int>();
            getMin = new Stack<int>();
        }

        public void Push(int x)
        {
            if (getMin.Count == 0)
            {
                getMin.Push(x);
            }
            else
            {
                if (x <= getMin.Peek()) getMin.Push(x);
            }

            data.Push(x);
        }

        public void Pop()
        {
            var val = data.Pop();
            if (getMin.Count != 0)
                if (val == getMin.Peek())
                    getMin.Pop();
        }

        public int Top()
        {
            return data.Peek();
        }

        public int Min()
        {
            return getMin.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.Min();
     */
}