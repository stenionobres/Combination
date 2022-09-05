using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var C = new int[combination.Count];
            var LI = 0;
            var CSN = 0;

            for (int i = 1; i <= combination.Count - 1; i++)
            {
                if (i != 1) C[i] = C[i - 1];

                C[i]++;

                var R = CombinationCoefficient.Calculate(totalElements - C[i], combination.Count - i);
                LI = LI + R;

                while (C[i] < combination[i-1])
                {
                    C[i]++;
                    R = CombinationCoefficient.Calculate(totalElements - C[i], combination.Count - i);
                    LI = LI + R;
                }

                LI = LI - R;
            }

            CSN = LI + combination[combination.Count - 1];

            if (combination.Count - 2 >= 0) CSN = CSN - combination[combination.Count - 2];

            return CSN;
        }
    }
}
