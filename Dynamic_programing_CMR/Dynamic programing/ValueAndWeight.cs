using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_programing
{
    class ValueAndWeight
    {
        private int weight, value;

        public int getWeight()
        {
            return weight;
        }

        public int getValue()
        {
            return value;
        }

        public ValueAndWeight(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
        }

        public bool equals(object obj)
        {
            if(obj.GetType() == typeof(ValueAndWeight))
            {
                ValueAndWeight that = (ValueAndWeight)obj;
                return this.value == that.value && this.weight == that.weight;
            }
            return false;
        }
    }
}
