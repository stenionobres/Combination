using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    // calculate a CSN (combinatorial sequence number)
    class CSN
    {
        private int n;
        private int[] combination;
        private Fatorial fatorial;
        public CSN(int n, int[] sequence)
        {
            this.n = n;
            combination = sequence;
            fatorial = new Fatorial();
        }
        public double calculate()
        {
            var x = 0d;
            var r = combination.Length;
            for (int i = 1; i <= r; i++)
            {
                var k = n - getNumber(combination[r - i]);

                if (k >= i)
                {
                    x = x + (fatorial.calculate(k) / (fatorial.calculate(i) * fatorial.calculate(k - i)));
                }
            }

            return (fatorial.calculate(n) / (fatorial.calculate(r) * fatorial.calculate(n - r))) - x;
        }

        public int[] generateCombination(int numbersPerCombination, int lexicographicalIndex)
        {
            var c = new int[numbersPerCombination];
            var li = 0d;
            var p1 = numbersPerCombination - 2;

            for (int i = 0; i <= p1; i++)
            {
                c[i] = 0;
                if (i != 0)
                {
                    c[i] = c[i - 1];
                }

                c[i] = c[i] + 1;

                var N = n - c[i];
                var K = numbersPerCombination - (i + 1);

                var r1 = fatorial.calculate(N) / (fatorial.calculate(K) * fatorial.calculate(N - K));

                li = li + r1;

                while(li < lexicographicalIndex)
                {
                    c[i] = c[i] + 1;

                    N = n - c[i];
                    K = numbersPerCombination - (i + 1);

                    r1 = fatorial.calculate(N) / (fatorial.calculate(K) * fatorial.calculate(N - K));

                    li = li + r1;
                }

                li = li - r1;
            }

            c[p1 + 1] = c[p1] + lexicographicalIndex - (int)li;

            return c;
        }

        private int getNumber(int value)
        {
            return value + 1;
        }

    }
}
