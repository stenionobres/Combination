using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Combination.Core
{
    public class LotofacilResults
    {
        public string Path { get; }
        public string Filename { get; }
        public Dictionary<string, List<int>> Results { get; } = new Dictionary<string, List<int>>();

        public LotofacilResults(string path, string fileName)
        {
            Path = path;
            Filename = fileName;
            var rd = new StreamReader($"{Path}/{Filename}");
            var linha = string.Empty;

            while ((linha = rd.ReadLine()) != null)
            {
                var components = linha.Split('=');
                var id = components[0];
                var result = components[1];
                var numbers = result.Split(',');
                var listOfNumbers = numbers.Select(n => int.Parse(n)).ToList();

                listOfNumbers.Sort();

                Results.Add(id, listOfNumbers);
            }
        }
    }
}
