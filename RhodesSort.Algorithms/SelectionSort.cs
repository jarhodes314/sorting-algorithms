﻿using System;
using System.Collections.Generic;

namespace RhodesSort.Algorithms
{
    public class SelectionSort : SortingAlgorithm
    {

        public override IList<T> Sort<T>(IList<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var provisionalSmallest = list[i];
                int provisionalIndex = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    // select smallest item in unsorted portion 
                    if(list[j].CompareTo(provisionalSmallest) < 1)
                    {
                        provisionalSmallest = list[j];
                        provisionalIndex = j;
                    }
                }

                // swap element i and the smallest
                list[provisionalIndex] = list[i];
                list[i] = provisionalSmallest;
            }

            return list;
        }

        public SelectionSort()
        {
            SpeedMultiplier = 5;
        }

        public override string ToString()
        {
            return "Selection sort";
        }
    }
}
