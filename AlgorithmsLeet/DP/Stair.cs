using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class Stair
    {
        public int GetWaysOfClimb(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            return GetWaysOfClimb(n - 1) + GetWaysOfClimb(n - 2);

        }

        public int GetWaysOfClimbDP(int n)
        {
            throw new NotImplementedException();
        }
    }
}
