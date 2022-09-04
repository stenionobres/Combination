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

            var csn = new CSN(10, new int[] { 1, 2, 3, 4, 5 });
            //var csn = new CSN(25, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            //var csn = new CSN(25, new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });
            var csnValue = csn.calculate();
            
            var combinationGenerate = csn.generateCombination(15, 1);
           

            LotofacilResults.process();
        }
    }
}
