using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_programing
{
    class KnapSack
    {
        private int maxWeight = 0;

        private List<ValueAndWeight> valueAndWeights = null;

        public KnapSack(int maxWeight, List<ValueAndWeight> valueAndWeights)
        {
            this.maxWeight = maxWeight;
            this.valueAndWeights = valueAndWeights;
        }

        public List<ValueAndWeight> getOptimalItems()
        {
            /*
             *for(int w = 0; w = maxWeight; w++)
             * {
             *  valuAndWeights[0,w] = 0;
             *  }
             *  for(int i = 1; i = n; i++)
             *  {
             *      for(int w = 1; w = maxWeight; w++)
             *      {
             *          if(wi>w)
             *          {
             *              valueAndWeights[i,w] = valueandWeights[i-1,w];
             *          }
             *          else
             *          {
             *              valueAndWeights[i,w] = max(valueAndWeights[i-1,w], valueAndWeights[i,w].value + valueAndWeight[i-1, w - wi]);
             *          }
             *      }
             *  }
             */ 

            //finish 
            return new List<ValueAndWeight>();
        }

        public int getMaxValue()
        {
            //reutnr getOptimalItems();
            return 90;
        }

        //order is i,w
        public int[][] getTable()
        {
            return new int[0][];
        }
    }
}
