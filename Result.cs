using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblemFinal
{
    class Result
    {
        public List<Item> SelectedItems;
        public int TotalValue;
        public int TotalWeight;

        public Result(List<Item> selectedItems, int totalValue, int totalWeight)
        {
            SelectedItems = selectedItems;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }

        public override string ToString()
        {
            string resultString = "\nItems selected: ";
            for (int i = 0; i < SelectedItems.Count; i++)
            {
                resultString = resultString + SelectedItems[i].originalIndex.ToString() + ", ";
            }
            resultString = resultString + "\n" + "Total value: " + TotalValue.ToString() + "\n" + "Total weight: " + TotalWeight.ToString();

            return resultString;
        }
    }
}
