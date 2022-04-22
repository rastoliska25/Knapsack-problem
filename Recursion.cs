using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_problem
{
    internal class Recursion
    {
        string items = "";
        int item;

        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        private int knapSack(int[] inputNumberArray, int maxNumber, int itemsCount)
        {
            if (itemsCount == 0 || maxNumber == 0)
                return 0;

            if (inputNumberArray[itemsCount - 1] > maxNumber)
                return knapSack(inputNumberArray, maxNumber, itemsCount - 1);

            else
                return max(inputNumberArray[itemsCount - 1]
                           + knapSack(inputNumberArray, maxNumber - inputNumberArray[itemsCount - 1], itemsCount - 1),
                           knapSack(inputNumberArray, maxNumber, itemsCount - 1));
        }

        public string itemsUsed(int[] inputNumberArray, int maxNumber, int itemsCount)
        {
            int resultNumber = knapSack(inputNumberArray, maxNumber, itemsCount);
            string result = "Sum of numbers combination created from inserted numbers: " + resultNumber.ToString();// + "\n\n" + "Selected numbers combination: " + items;
            return result;
        }
    }
}
