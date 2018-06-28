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
                    var a = list[i];
                    var b = list[i + 1];
                    if (a.CompareTo(b) > 0)
                    {
                        // pair out of order -- swap them
                        //var tmp = list[i];
                        list[i] = b; //list[i + 1];
                        list[i + 1] = a;// tmp;
                        swapsMade = true;
                    }
                }

                n--;
            }

            return list;
        }

        public BubbleSort()
        {
            SpeedMultiplier = 12;
        }

        public override string ToString()
        {
            return "Bubble sort";
        }
    }
}
