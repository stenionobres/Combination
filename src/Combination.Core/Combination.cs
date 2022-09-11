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
    }
}
