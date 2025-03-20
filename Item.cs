using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblemFinal
{
    class Item
    {
        public int value;
        public int weight;
        public double ratio;
        public int originalIndex;

        public Item(int value, int weight, int originalIndex)
        {
            this.value = value;
            this.weight = weight;
            this.ratio = (double) this.value / this.weight;
            this.originalIndex = originalIndex;
        }
    }
}
