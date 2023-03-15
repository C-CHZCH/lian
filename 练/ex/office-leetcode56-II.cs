namespace ex;

//在一个数组 nums 中除一个数字只出现一次之外，其他数字都出现了三次。请找出那个只出现一次的数字。
public class OfficeLeetcode56Ii
{
    public int SingleNumber(int[] nums)
    {
        //出现三次则可以说明二进制对应的位上出现的次数应该可以被3取余,那么如果我们的目标数也在其中呢?那么有一些位上的time对3取余必定为1,而这些位就为我们所需要的目标数所占的位.
        var res = 0;
        for (var i = 0; i < 32; i++) //每个数都可表达为32位的二进制数
        {
            // 对于int数的每一位 计算该位上的和
            var time = nums.Sum(num => (num >> i) & 1);
            // 将time对3取余即为res在该位的值,取余结果只有0或1,1则代表我们想要的res在该位上的二进制表达为1
            res += (time % 3) << i;
        }

        return res;
    }
}