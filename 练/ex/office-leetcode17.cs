using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class Solution_office17
    {
        public int[] PrintNumbers(int n)
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(9);
            }

            int theMax = Int32.Parse(sb.ToString());
            int[]res = new int[theMax];
            for (int i = 1; i <= theMax; i++)
            {
                res[i] = i;
            }
            return res;
        }
    }
}
