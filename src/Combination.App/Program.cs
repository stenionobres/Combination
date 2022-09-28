using System.Linq;
using Combination.Core;
using System.Collections.Generic;

namespace Combination.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var lotofacilResults = new LotofacilResults("../../../../../resources/", "resultadosltf.txt");
            var groupingCSN = new GroupingCSN(totalElements: 25, combinationSize: 15, groupSize: 100000);
            var groupingCSNCounter = new Dictionary<int, int>();

            foreach (var lotofacilResult in lotofacilResults.Results)
            {
                var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
                combination.buildWith(lotofacilResult.Value);

                var csnGroup = groupingCSN.GetGroup(combination.CSN);

                if (groupingCSNCounter.ContainsKey(csnGroup) == false)
                {
                    groupingCSNCounter.Add(csnGroup, 0);
                }

                groupingCSNCounter[csnGroup]++;
            }

            var groupingCSNCounterOrdered = groupingCSNCounter.OrderByDescending(g => g.Value);
        }
    }
}
