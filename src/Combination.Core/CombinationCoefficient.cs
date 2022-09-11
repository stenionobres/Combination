using System;

namespace Combination.Core
{
    public class CombinationCoefficient
    {
        public static int Calculate(int totalElements, int combinationSize)
        {
            if (totalElements < combinationSize) return 0;
            if (totalElements < 0) throw new ApplicationException("Total elements must be greater than or equal to 0");
            if (combinationSize < 0) throw new ApplicationException("Combination size must be greater than or equal to 0");

            var totalElementsFatorial = Fatorial.Get(totalElements);
            var combinationSizeFatorial = Fatorial.Get(combinationSize);
            var differenceFatorial = Fatorial.Get(totalElements - combinationSize);
            var combinationCoefficient = (int)(totalElementsFatorial / (combinationSizeFatorial * differenceFatorial));

            return combinationCoefficient;
        }
    }
}
