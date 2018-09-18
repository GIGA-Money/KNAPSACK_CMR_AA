using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dynamic_programing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ValueAndWeight> valueAndWeights = new List<ValueAndWeight>();
            valueAndWeights.Add(new ValueAndWeight(10, 5));
            valueAndWeights.Add(new ValueAndWeight(40, 4));
            valueAndWeights.Add(new ValueAndWeight(30, 6));
            valueAndWeights.Add(new ValueAndWeight(50, 3));

            KnapSack knapSack = new KnapSack(10,valueAndWeights);

            Debug.Assert(knapSack.getMaxValue() == 90, "pass 1\n");

            List<ValueAndWeight> solution = knapSack.getOptimalItems();

            Debug.Assert(solution.Count() == 2, "pass 2\n");
            Debug.Assert(solution.Contains(new ValueAndWeight(40, 4)),"pass 3\n");
            Debug.Assert(solution.Contains(new ValueAndWeight(50, 3)), "pass 4\n");

            int[][] table = knapSack.getTable();
            Debug.Assert(table[4][10] == 90, "pass 5\n");
            Debug.Assert(table[4][3] == 50, "pass 6\n");
        }
    }
}
