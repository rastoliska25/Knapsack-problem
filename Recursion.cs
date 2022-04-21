using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_problem
{
    internal class Recursion
    {

        private int knapsack(int[] inputNumberArray, int maxNumber, int itemNumber)
        {
            if (maxNumber == 0 || itemNumber == inputNumberArray.Length)
            {
                return 0;
            }
            if (inputNumberArray[itemNumber] > maxNumber)
                return knapsack(inputNumberArray, maxNumber, itemNumber + 1);

            int rValue = inputNumberArray[itemNumber] + knapsack(inputNumberArray, maxNumber - inputNumberArray[itemNumber], itemNumber + 1);

            return rValue;
        }

        public string itemsUsed(int[] inputNumberArray, int maxNumber, int itemNumber)
        {
            int resultNumber;
            string result;
            resultNumber = knapsack(inputNumberArray, maxNumber, itemNumber);

            result = "Max number created from inserted numbers: " + resultNumber.ToString() + "\n\n" + "From numbers: " + (inputNumberArray[itemNumber]).ToString();
            return result;
        }
    }
}
