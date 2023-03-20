namespace ex;

public class SolutionOffice31
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        var IndexPush = 0;
        var IndexPop = 0;
        var st = new Stack<int>();
        while (IndexPush != pushed.Length)
        {
            if (st.Count() == 0)
            {
                st.Push(pushed[IndexPush]);
                IndexPush++;
                continue;
            }

            if (st.Peek() != popped[IndexPop])
            {
                st.Push(pushed[IndexPush]);
                IndexPush++;
            }
            else
            {
                while (st.Count() != 0 && st.Peek() == popped[IndexPop])
                {
                    st.Pop();
                    IndexPop++;
                }
            }
        }

        while (st.Count != 0)
            if (st.Peek() != popped[IndexPop])
            {
                return false;
            }
            else
            {
                st.Pop();
                IndexPop++;
            }

        return true;
    }
}