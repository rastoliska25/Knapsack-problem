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
        private int knapsack(int[] inputNumberArray, int maxNumber, int itemNumber)
        {
            if (maxNumber == 0 || itemNumber == inputNumberArray.Length)
            {
                return 0;
            }
            if (inputNumberArray[itemNumber] > maxNumber)
                return knapsack(inputNumberArray, maxNumber, itemNumber + 1);

            item = inputNumberArray[itemNumber];
            items = items + "   " + item.ToString();
            int rValue = inputNumberArray[itemNumber] + knapsack(inputNumberArray, maxNumber - inputNumberArray[itemNumber], itemNumber + 1);

            return rValue;
        }

        public string itemsUsed(int[] inputNumberArray, int maxNumber, int itemNumber)
        {
            int resultNumber = knapsack(inputNumberArray, maxNumber, itemNumber);
            string result = "Sum of numbers combination created from inserted numbers: " + resultNumber.ToString() + "\n\n" + "Selected numbers combination: " + items;
            return result;
        }
    }
}
