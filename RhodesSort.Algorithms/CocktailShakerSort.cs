using System;
using System.Collections.Generic;
namespace RhodesSort.Algorithms
{
    public class CocktailShakerSort : SortingAlgorithm
    {
        public override IList<T> Sort<T>(IList<T> list)
        {
            var swapsMade = true;
            var n = list.Count; //number of unsorted items

            while (swapsMade)
            {
                // run an iteration of bubble sort first

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

                // and then do the same, but in the opposite direction

                for (int i = n - 1; i > 0; i--)
                {
                    if (list[i].CompareTo(list[i - 1]) < 0)
                    {
                        // pair out of order -- swap them
                        var tmp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = tmp;
                        swapsMade = true;
                    }
                }
            }

            return list;
        }

        public override string ToString()
        {
            return "Cocktail shaker sort";
        }
    }
}
