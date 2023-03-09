using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{

        public class Solution_office10
        {
            public int NumWays(int n)
            {
                 int [] dp = new int[2];
                dp[0] = 1;
                dp[1] = 1;
                int res = 1;
                for (int i = 2; i <= n; i++)
                {
                    res = (dp[0] + dp[1])% 1000000007;
                    Console.WriteLine(res);
                    dp[0] = dp[1];
                    dp[1] = res;
                }
                return res;
            }
        }
    
}
