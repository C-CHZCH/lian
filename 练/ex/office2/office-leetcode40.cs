namespace ex;

public class SolutionOffice40
{
    public int[] GetLeastNumbers(int[] arr, int k)
    {
        Array.Sort(arr);
        var res = new int[k];
        for (var i = 0; i < k; i++) res[i] = arr[i];

        return res;
    }
}