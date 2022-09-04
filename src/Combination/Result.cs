using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    public class Result
    {
        public int drawingNumber { get; set; }
        public List<int> numbers { get; set; } = new List<int>();
        public double CSN { get; set; }

        public override string ToString()
        {
            return "{" + string.Join(",", numbers) + "} " + $"CSN: {CSN}";
        }
    }
}
