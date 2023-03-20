namespace ex;

public class OfficeLeetcode56I
{
    //一个整型数组 nums 里除两个数字之外，其他数字都出现了两次。请写程序找出这两个只出现一次的数字。要求时间复杂度是O(n)，空间复杂度是O(1)
    public int[] SingleNumbers(int[] nums)
    {
        var sum = nums.Aggregate(0,
            (current, num) => current ^ num); //整个nums作异或,但其实结果是这两个不同的数的异或结果(因为分别与两个相同的数做异或,并不会对res产生影响)
        //找到sum中第几位是1
        var target = 1; //初始位0001
        while ((target & sum) == 0) //如果target第一个二进制位不为1，就将target左移一位位0010，然后与其相与，
            ////判断ret第二位是否为一.按此循环，直到找到ret的第一个为1的二进制位，因为这个1的位置就是我们给两个不同数划分组的关键依据
            target = target << 1;
        int a = 0, b = 0;
        foreach (var num in nums)
            if ((num & target) == 0) //划分到第一组
                a ^= num;
            else //划分到第二组
                b ^= num;
        int[] ans = { a, b };
        return ans;
    }
}