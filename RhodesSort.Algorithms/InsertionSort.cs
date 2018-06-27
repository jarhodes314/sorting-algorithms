using System;
using System.Collections.Generic;
namespace RhodesSort.Algorithms
{
    public class InsertionSort : SortingAlgorithm
    {
        public override IList<T> Sort<T>(IList<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int j = i;

                while(j > 0 && list[j - 1].CompareTo(list[j]) > 0)
                {
                    // swap element into correct place
                    var tmp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = tmp;

                    // update j to new position for next swap
                    j--;
                }
            }

            return list;
        }

        public override string ToString()
        {
            return "Insertion sort";
        }
    }
}
