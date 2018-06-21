using System;
using System.Collections.Generic;
namespace sorting_algorithms
{
    public class CocktailShakerSort : SortingAlgorithm
    {
        public override List<T> Sort<T>(List<T> list)
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

                n--;

                // and then do the same, but in the opposite direction

                for (int i = n; i > 0; i++)
                {
                    if (list[i].CompareTo(list[i - 1]) > 0)
                    {
                        // pair out of order -- swap them
                        var tmp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = tmp;
                        swapsMade = true;
                    }
                }

                n--;
            }

            return list;
        }

        public override string ToString()
        {
            return "Cocktail shaker sort";
        }
    }
}
