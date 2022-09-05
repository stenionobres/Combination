using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var NUM = new int[combination.Count + 1];
            var C = new int[combination.Count + 1];
            var LI = 0;
            var CSN = 0;

            for (int i = 1; i <= combination.Count; i++)
            {
                NUM[i] = combination[i - 1];
            }

            for (int i = 1; i <= combination.Count - 1; i++)
            {
                C[i] = 0;
                if (i != 1) C[i] = C[i - 1];

                C[i] = C[i] + 1; //2001

                var R = CombinationCoefficient.Calculate(totalElements - C[i], combination.Count - i);
                LI = LI + R;

                while (C[i] < NUM[i])
                {
                    C[i] = C[i] + 1; //2001
                    R = CombinationCoefficient.Calculate(totalElements - C[i], combination.Count - i);
                    LI = LI + R;
                }

                LI = LI - R;
            }

            CSN = LI + NUM[combination.Count] - NUM[combination.Count - 1];

            return CSN;
        }
    }
}
