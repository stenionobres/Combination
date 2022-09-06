using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var R = 0;
            var LI = 0;

            for (int i = 1, j = 0; i <= combination.Count - 1; i++)
            {
                do
                {
                    j++;
                    R = CombinationCoefficient.Calculate(totalElements - j, combination.Count - i);
                    LI = LI + R;
                } while (j < combination[i - 1]);

                LI = LI - R;
            }

            var CSN = LI + combination[combination.Count - 1];

            if (combination.Count - 2 >= 0) CSN = CSN - combination[combination.Count - 2];

            return CSN;
        }
    }
}
