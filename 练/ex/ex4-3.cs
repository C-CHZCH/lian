namespace ex;

public class Ex43
{
    //简单贪心，从右边开始找
    public int[] PrevPermOpt1(int[] arr)
    {
        var n = arr.Length;
        for (var i = n - 2; i >= 0; i--)
            if (arr[i] > arr[i + 1])
            {
                var j = n - 1;
                while (arr[j] >= arr[i] || arr[j] == arr[j - 1]) j--;
                (arr[i], arr[j]) = (arr[j], arr[i]);
                break;
            }

        return arr;
    }
}