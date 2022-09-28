using NUnit.Framework;
using Combination.Core;

namespace Combination.Tests
{
    [TestFixture]
    public class GroupingCSNTests
    {
        [Test]
        public void TestCSN()
        {
            var groupingCSN = new GroupingCSN(totalElements: 10, combinationSize: 3, groupSize: 20);
            

        }

        [Test]
        public void TestLoadLotofacilResults()
        {
            var lotofacilResults = new LotofacilResults("../../../../../resources/", "resultadosltf.txt");


        }
    }
}
