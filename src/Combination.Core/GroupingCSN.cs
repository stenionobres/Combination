using System;
using System.Collections.Generic;

namespace Combination.Core
{
    public class GroupingCSN
    {
        public int TotalElements { get; }
        public int CombinationSize { get; }
        public int GroupCount { get; }
        public int GroupSize { get; }
        public int NumberOfCombinations { get; }
        public Dictionary<int, int> CsnByGroup { get; } = new Dictionary<int, int>();

        public GroupingCSN(int totalElements, int combinationSize, int groupSize)
        {
            if (groupSize < 1) throw new ApplicationException("Group size must be greater than or equal to 1");

            TotalElements = totalElements;
            CombinationSize = combinationSize;
            GroupSize = groupSize;
            NumberOfCombinations = CombinationCoefficient.Calculate(TotalElements, CombinationSize);

            for (int i = 0, groupNumber = 1; i < NumberOfCombinations;)
            {
                for (int groupIndex = 0; groupIndex < groupSize && i < NumberOfCombinations; groupIndex++, i++)
                {
                    var csn = i + 1;
                    CsnByGroup.Add(csn, groupNumber);
                    GroupCount = groupNumber;
                }
                groupNumber++;
            }
        }

        public int GetGroup(int csn)
        {
            if (CsnByGroup.ContainsKey(csn))
            {
                return CsnByGroup[csn];
            }

            throw new ApplicationException("CSN not found in CsnByGroup");
        }
    }
}
