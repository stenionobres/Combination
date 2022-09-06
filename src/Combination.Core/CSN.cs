using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var combinationSize = combination.Count;
            var csn = CombinationCoefficient.Calculate(totalElements, combinationSize);

            for (int i = 0; i < combinationSize; i++)
            {
                if (totalElements - combination[i] >= combinationSize - i)
                    csn = csn - CombinationCoefficient.Calculate(totalElements - combination[i], combinationSize - i);
            }

            return csn;
        }
    }

    /*
     * 
     * 
        // Algoritmo refatorado a partir do algoritmo citado no link https://saliu.com/bbs/messages/348.html
        // Esse algoritmo não funciona para cenários com 60 números e combinações com 6 números
        var R = 0;
        var LI = 0;

        for (int i = 0, j = 0; i < combination.Count - 1; i++)
        {
            while (j < combination[i])
            {
                j++;
                R = CombinationCoefficient.Calculate(totalElements - j, combination.Count - (i + 1));
                LI = LI + R;
            }

            LI = LI - R;
        }

        var CSN = LI + combination[combination.Count - 1];

        if (combination.Count - 2 >= 0) CSN = CSN - combination[combination.Count - 2];

        return CSN;

    *
    *
    */
}
