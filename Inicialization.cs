using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_problem
{
    internal class Inicialization
    {
        int[] inputNumbers;
        int[] itemValues;

        public void recursion()
        {
            inputNumbers[0] = 18;
            inputNumbers[1] = 19;
            inputNumbers[2] = 17;
            inputNumbers[3] = 11;
            inputNumbers[4] = 21;
            inputNumbers[5] = 14;

            itemValues[0] = 18;
            itemValues[1] = 19;
            itemValues[2] = 17;
            itemValues[3] = 11;
            itemValues[4] = 21;
            itemValues[5] = 14;

            Recursion recursion = new Recursion();
            recursion.knapsack(inputNumbers, itemValues, 100, 0);
        }
    }
}
