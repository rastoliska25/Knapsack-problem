using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_problem
{
    internal class Recursion
    {
        public int knapsack(int[] inputNumberArray, int[] inputNumberArrayValue, int itemsQuantity, int itemNumber) //inputNumberArray = inputNumberArrayValue - nazov zodpoveda hodnote
        {
            if (itemsQuantity == 0 || itemNumber == inputNumberArray.Length)
            {
                return 0;
            }
            if (inputNumberArray[itemNumber] > itemsQuantity)
                return knapsack(inputNumberArray, inputNumberArrayValue, itemsQuantity, itemNumber + 1);

            int rMax = inputNumberArrayValue[itemNumber] + knapsack(inputNumberArray, inputNumberArrayValue, itemsQuantity - inputNumberArray[itemNumber], itemNumber + 1);
            int lMax = knapsack(inputNumberArray, inputNumberArrayValue, itemsQuantity, itemNumber + 1);
            return Math.Max(rMax, lMax);
        }
    }
}
