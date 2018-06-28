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
                    T a = list[i];
                    T b = list[i + 1];
                    if (a.CompareTo(b) > 0)
                    {
                        // pair out of order -- swap them
                        list[i] = b;
                        list[i + 1] = a;
                        swapsMade = true;
                    }
                }

                // and then do the same, but in the opposite direction

                for (int i = n - 1; i > 0; i--)
                {
                    T a = list[i];
                    T b = list[i - 1];
                    if (a.CompareTo(b) < 0)
                    {
                        // pair out of order -- swap them
                        list[i] = b;
                        list[i - 1] = a;
                        swapsMade = true;
                    }
                }
            }

            return list;
        }

        public CocktailShakerSort()
        {
            SpeedMultiplier = 12;
        }

        public override string ToString()
        {
            return "Cocktail shaker sort";
        }
    }
}
