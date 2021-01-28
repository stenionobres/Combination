using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    public static class LotofacilResults
    {
        private static Dictionary<int, Result> results = new Dictionary<int, Result>();

        public static void process()
        {
            StreamReader rd = new StreamReader(@"..\..\..\lotofacil-results.csv");
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

                var csn = new CSN(25, result.numbers.ToArray());

                result.CSN = csn.calculate();

                results.Add(drawingNumber, result);
            }

            rd.Close();

            using (var writer = new StreamWriter(@"..\..\..\results-csn.csv"))
            {
                foreach (var item in results.OrderBy(r => r.Key))
                {
                    var result = $"{item.Key};{string.Join(";", item.Value.numbers)};{item.Value.CSN}\n";
                    writer.Write(result);
                }
            }

            

            
        }
    }
}
