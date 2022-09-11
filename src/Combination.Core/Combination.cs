using System.Collections.Generic;

namespace Combination.Core
{
    public class Combination
    {
        public int TotalElements { get; }
        public int CombinationSize { get; }
        public int CSN { get; }
        public List<int> Elements { get; private set; }

        public Combination(int totalElements, int combinationSize)
        {
            TotalElements = totalElements;
            CombinationSize = combinationSize;
        }

        public void buildWith(List<int> elements)
        {
            Elements = elements;
        }
    }
}
