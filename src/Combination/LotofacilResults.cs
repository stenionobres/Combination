using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Combination
{
    public static class LotofacilResults
    {
        private static Dictionary<int, Result> results = new Dictionary<int, Result>();
        private static Dictionary<int, int> csnGroups = new Dictionary<int, int>() 
        {
            {01, 0},
            {02, 0},
            {03, 0},
            {04, 0},
            {05, 0},
            {06, 0},
            {07, 0},
            {08, 0},
            {09, 0},
            {10, 0},
            {11, 0},
            {12, 0},
            {13, 0},
            {14, 0},
            {15, 0}
        };

        public static void process()
        {
            //StreamReader rd = new StreamReader(@"..\..\..\lotofacil-results.csv");
            StreamReader rd = new StreamReader(@"..\..\..\resultadosltf.csv");
            string linha = null;
            string[] colunas = null;

            while ((linha = rd.ReadLine()) != null)
            {
                colunas = linha.Split(';');
                if (char.IsDigit(colunas[0][0]) == false) continue;

                var drawingNumber = int.Parse(colunas[0]);
                var result = new Result();

                result.drawingNumber = drawingNumber;

                for (int i = 1; i < colunas.Length; i++)
                {
                    result.numbers.Add(int.Parse(colunas[i]));
                }

                result.numbers.Sort();

                var csn = new CSN(15, result.numbers.ToArray());

                result.CSN = csn.calculate();

                results.Add(drawingNumber, result);
            }

            rd.Close();

            using (var writer = new StreamWriter(@"..\..\..\results-csn.csv"))
            {
                foreach (var item in results.OrderBy(r => r.Key))
                {
                    var result = $"{item.Key};{string.Join(";", item.Value.numbers)};{item.Value.CSN}\n";
                    var csnGroupId = GetCSNGroupId(item.Value.CSN);

                    csnGroups[csnGroupId]++;

                    writer.Write(result);
                }
            }
            
        }

        private static int GetCSNGroupId(double csn)
        {
            // Lotofacil: C(25,15) = 3.268.760

            if (csn >= 0_000_001 && csn <= 0_217_918) return 01; //grupo de 217.917 combinacoes
            if (csn >= 0_217_919 && csn <= 0_435_836) return 02; //grupo de 217.917 combinacoes
            if (csn >= 0_435_837 && csn <= 0_653_754) return 03; //grupo de 217.917 combinacoes
            if (csn >= 0_653_755 && csn <= 0_871_672) return 04; //grupo de 217.917 combinacoes
            if (csn >= 0_871_673 && csn <= 1_089_590) return 05; //grupo de 217.917 combinacoes
            if (csn >= 1_089_591 && csn <= 1_307_508) return 06; //grupo de 217.917 combinacoes
            if (csn >= 1_307_509 && csn <= 1_525_426) return 07; //grupo de 217.917 combinacoes
            if (csn >= 1_525_427 && csn <= 1_743_344) return 08; //grupo de 217.917 combinacoes
            if (csn >= 1_743_345 && csn <= 1_961_262) return 09; //grupo de 217.917 combinacoes
            if (csn >= 1_961_263 && csn <= 2_179_180) return 10; //grupo de 217.917 combinacoes
            if (csn >= 2_179_181 && csn <= 2_397_098) return 11; //grupo de 217.917 combinacoes
            if (csn >= 2_397_099 && csn <= 2_615_016) return 12; //grupo de 217.917 combinacoes
            if (csn >= 2_615_017 && csn <= 2_832_934) return 13; //grupo de 217.917 combinacoes
            if (csn >= 2_832_935 && csn <= 3_050_852) return 14; //grupo de 217.917 combinacoes

            return 15; //grupo de 217.907 combinacoes
        }
    }
}
