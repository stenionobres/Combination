using System;
using System.Collections.Generic;

namespace Combination.Core
{
    public class CSN
    {
        public static int Calculate(int totalElements, List<int> combination)
        {
            if (combination == null) throw new ApplicationException("Combination parameter cannot be null");

            var combinationSize = combination.Count;
            var csn = CombinationCoefficient.Calculate(totalElements, combinationSize);

            combination.Sort();

            for (int i = 0; i < combinationSize; i++)
            {
                if (totalElements - combination[i] >= combinationSize - i)
                    csn = csn - CombinationCoefficient.Calculate(totalElements - combination[i], combinationSize - i);
            }

            return csn;
        }

        public static List<int> GenerateCombination(int totalElements, int combinationSize, int csn)
        {
            
            var combination = new List<int>();
            var max = totalElements;
            var combLength = combinationSize;
            var id = csn;

            var tId = CombinationCoefficient.Calculate(max, combLength) - id;
            for (int i = combLength; i > 0; i--)
            {
                var tVal = 0;
                bool done = false;
                int pos = 0;
                while (!done)
                {
                    if (max - pos < i)
                    {
                        pos++;
                        break;
                    }

                    var t = CombinationCoefficient.Calculate(max - pos, i);
                    if (t <= tId)
                    {
                        tVal = t;
                        done = true;
                    }
                    pos++;
                }
                tId -= tVal;
                combination.Add(pos - 1);
            }

            return combination;
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
