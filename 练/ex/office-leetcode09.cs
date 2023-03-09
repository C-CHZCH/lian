using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class CQueue
        {
            readonly Stack<int> _pre = new Stack<int>();
            readonly Stack<int> _post = new Stack<int>();

            public CQueue()
            {

            }

            public void AppendTail(int value)
            {
                _pre.Push(value);
            }

            public int DeleteHead()
            {
                if (_post.Count == 0)
                {
                    while (_pre.Count != 0)
                    {
                        _post.Push(_pre.Pop());
                    }
                }
                if (_post.Count == 0)
                {
                    return -1;
                }
                else
                {
                    int deleteItem = _post.Pop();
                    return deleteItem;
                }
            }
        }
    
}
