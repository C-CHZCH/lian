using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class Solution_office11
    {
        //关键在于理解这个旋转以及这个二段性的理解，无论这个数组进行多少次旋转，二段性仍然是保持不变的。（仔细查看此题对于旋转的理解）
        public int MinArray(int[] numbers)
        {
            int l = 0, r = numbers.Length - 1;
            //先去掉尾部和首元素相同的元素，恢复数组的二段性。这里并不会影响最终的结果判定，因为假设这个相同的元素就是旋转点，那么我们还是保留了前段的相同元素。
            //处理之后，数组分为2段：前一段的元素都大于等于numbers[0]
            //后一段元素都小于numbers[0]
            //我们的目标是找到数组的最小值，根据题意，就是数组中第一个小于numbers[0]的元素，
            //也就是后一段的第一个元素
            while (l < r && numbers[l] == numbers[r]) r--;
            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if (numbers[mid] < numbers[0]) r = mid;
                else l = mid + 1;
            }
            //判断是找到了还是没找到，如果找到了，返回找到的值，如果没找到，那第一个元素就是最小的
            if (numbers[r] < numbers[0]) return numbers[r];
            else return numbers[0];
        }
    }
}
