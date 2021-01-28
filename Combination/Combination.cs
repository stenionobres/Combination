using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    public class Combination
    {
        private readonly int n;
        private readonly int k;
        private readonly int[] data;
        
        public Combination(int n, int k)
        {
            this.n = n;
            this.k = k;
            this.data = new int[k];
            for (int i = 0; i < k; ++i)
            {
                data[i] = i;
            }
        } // ctor()

        public override string ToString()
        {
            string s = "{ ";
            for (int i = 0; i < k; ++i)
                s += data[i].ToString("00") + " ";
            s += "} csn: " + CSN() + " reverse: " + reverseCombination();
            return s;
        }
        public Combination Successor()
        {
            if (data[0] == n - k) // last combination element
                return null;
            Combination ans = new Combination(n, k);
            int i;
            for (i = 0; i < k; ++i)
                ans.data[i] = this.data[i];

            for (i = k - 1; i > 0 && ans.data[i] == n - k + i; --i);
                ++ans.data[i];

            for (int j = i; j < k - 1; ++j)
                ans.data[j + 1] = ans.data[j] + 1;

            return ans;
        } // Successor()

        private double CSN()
        {
            return new CSN(n, data).calculate();
        }

        private string reverseCombination()
        {
            var reserveCombination = new CSN(n, data).generateCombination(k, (int)CSN());

            string s = "{ ";
            for (int i = 0; i < k; ++i)
                s += reserveCombination[i].ToString("00") + " ";
            s += "}";

            return s;
        }

    } // class Combination
}
