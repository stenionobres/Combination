using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var V = totalElements;
            var K = combination.Count;
            var NUM = new int[K + 1];
            var C = new int[K + 1];
            var LI = 0;
            var CSN = 0;
            var P1 = K - 1;

            for (int i = 1; i <= K; i++)
            {
                NUM[i] = combination[i - 1];
            }

            for (int i = 1; i <= P1; i++)
            {
                C[i] = 0;
                if (i != 1) C[i] = C[i - 1];

                C[i] = C[i] + 1; //2001

                var R = CombinationCoefficient.Calculate(V - C[i], K - i);
                LI = LI + R;

                while (C[i] < NUM[i])
                {
                    C[i] = C[i] + 1; //2001
                    R = CombinationCoefficient.Calculate(V - C[i], K - i);
                    LI = LI + R;
                }

                LI = LI - R;
            }

            CSN = LI + NUM[K] - NUM[P1];

            return CSN;
        }
    }
}
