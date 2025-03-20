using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("KnapsackTest"), InternalsVisibleTo("KnapsackProblemApp")]
namespace KnapsackProblemFinal
{
    class Problem
    {
        public int numberOfItems;
        public List<Item> listOfItems;

        public Problem(int n, int seed)
        {
            this.numberOfItems = n;
            this.listOfItems = new List<Item>();

            Random random = new Random(seed);

            // Generating items
            for (int i = 0; i < numberOfItems; i++)
            {
                int randomValue = random.Next(1, 11);
                int randomWeight = random.Next(1, 11);
                Item randomItem = new Item(randomValue, randomWeight, i);
                listOfItems.Add(randomItem);
            }
        }

        public void Sort()
        {
            this.listOfItems.Sort((a, b) => (b.ratio).CompareTo(a.ratio));
        }

        public Result Solve(int capacity)
        {
            listOfItems.Sort((a, b) => (b.ratio).CompareTo(a.ratio));

            List<Item> selectedItems = new List<Item>();
            int totalValue = 0;
            int totalWeight = 0;

            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (totalWeight + listOfItems[i].weight <= capacity)
                {
                    selectedItems.Add(listOfItems[i]);
                    totalValue = totalValue + listOfItems[i].value;
                    totalWeight = totalWeight + listOfItems[i].weight;
                }
            }

            return new Result(selectedItems, totalValue, totalWeight);
        }
        public override string ToString()
        {
            string listContent = "";
            for (int i = 0; i < listOfItems.Count; i++)
            {
                listContent = listContent + "Item no.: " + i + "   Value: " + listOfItems[i].value.ToString() + "   Weight: " + listOfItems[i].weight.ToString() + "\n";
            }
            return listContent;
        }
    }
}
