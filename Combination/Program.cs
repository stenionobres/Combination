using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("\nEnter combination n-value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nEnter combination k-value: ");
            int k = int.Parse(Console.ReadLine());
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\nAll combinations: \n");
            Combination c = new Combination(n, k);
            var combinations = 0;
            while (c != null)
            {
                combinations++;
                Console.WriteLine(c.ToString());
                c = c.Successor();
            }
            stopwatch.Stop();
            Console.WriteLine($"\nCombinations: {combinations}");
            Console.WriteLine($"\nTime Elapsed: {stopwatch.Elapsed.ToString()}");
            Console.ReadLine();
            */

            /*
            Console.Write("\nEnter number: ");
            int number = int.Parse(Console.ReadLine());
            var fatorial = new Fatorial();
            Console.WriteLine($"\nFatorial: {fatorial.calculate(number)}");
            Console.ReadLine();
            */

            /*
            var csn = new CSN(15, new int[] { 6, 7, 16, 20, 28, 47 });
            csn.generateCombination(9, 1734);
            */

            LotofacilResults.process();
        }
    }
}
