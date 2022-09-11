using System;
using System.Collections.Generic;

namespace Combination.Core
{
    public class Combination
    {
        public int TotalElements { get; }
        public int CombinationSize { get; }
        public int CSN { get; private set; }

        public List<int> Elements { get; private set; }

        public Combination(int totalElements, int combinationSize)
        {
            TotalElements = totalElements;
            CombinationSize = combinationSize;
            CSN = -1;
        }

        public void buildWith(List<int> elements)
        {
            if (elements == null) throw new ApplicationException("Elements parameter cannot be null");
            if (elements.Count != CombinationSize) throw new ApplicationException("Elements parameter must be the same size of CombinationSize parameter");

            Elements = elements;
            CSN = calculateCSN();
        }

        public void buildWith(int csn)
        {
            if (csn < 1) throw new ApplicationException("CSN parameter must be greater than 0");

            CSN = csn;
            Elements = calculateCombination();
        }

        private int calculateCSN()
        {
            var csn = CombinationCoefficient.Calculate(TotalElements, CombinationSize);

            Elements.Sort();

            for (int i = 0; i < CombinationSize; i++)
            {
                if (TotalElements - Elements[i] >= CombinationSize - i)
                    csn = csn - CombinationCoefficient.Calculate(TotalElements - Elements[i], CombinationSize - i);
            }

            return csn;
        }

        private List<int> calculateCombination()
        {
            var combination = new List<int>();
            var remainingCSN = CombinationCoefficient.Calculate(TotalElements, CombinationSize) - CSN;

            for (int i = CombinationSize, partialCSN, pos = 0; i > 0; i--)
            {
                do
                {
                    partialCSN = CombinationCoefficient.Calculate(TotalElements - pos, i);
                    pos++;
                } while (partialCSN > remainingCSN);

                remainingCSN -= partialCSN;
                combination.Add(pos - 1);
            }

            return combination;
        }
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
