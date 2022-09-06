using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            var r = CombinationCoefficient.Calculate(totalElements, combination.Count);

            for (int i = 0; i < combination.Count; i++)
            {
                if (totalElements - combination[i] < combination.Count - i) continue;
                r = r - CombinationCoefficient.Calculate(totalElements - combination[i], combination.Count - i);
            }

            return r;
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
