using System;

namespace Knapsack_problem
{
    internal class Memoization
    {
        string items = "";
        int item;

        private int knapSack(int[] inputNumberArray, int maxNumber, int itemsCount)
        {
            int[] array = new int[maxNumber + 1];

            for (int i = 1; i < itemsCount + 1; i++)
            {
                for (int j = maxNumber; j >= 0; j--)
                {
                    if (inputNumberArray[i - 1] <= j)
                    {
                        array[j] = Math.Max(array[j], array[j - inputNumberArray[i - 1]] + inputNumberArray[i - 1]);
                    }
                }
            }
            return array[maxNumber];
        }

        public string itemsUsed(int[] inputNumberArray, int maxNumber, int itemsCount)
        {
            int resultNumber = knapSack(inputNumberArray, maxNumber, itemsCount);
            string result = "Sum of numbers combination created from inserted numbers: " + resultNumber.ToString(); // + "\n\n" + "Selected numbers combination: " + items;
            return result;
        }
    }
}
