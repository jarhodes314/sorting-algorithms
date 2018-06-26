using System;
using System.Collections.Generic;
namespace RhodesSort.Algorithms
{
    public class BubbleSort : SortingAlgorithm
    {
        public override IList<T> Sort<T>(IList<T> list)
        {
            bool swapsMade = true;
            var n = list.Count; //number of unsorted items

            while (swapsMade)
            {
                swapsMade = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        // pair out of order -- swap them
                        var tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                        swapsMade = true;
                    }
                }

                n--;
            }

            return list;
        }

        public override string ToString()
        {
            return "Bubble sort";
        }
    }
}
