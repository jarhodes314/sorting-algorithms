﻿using System;
using System.Collections.Generic;
namespace sorting_algorithm
{
    public class InsertionSort
    {
        public static List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 1; i < list.Count; i++)
            {
                int j = i;

                while(j > 0 && list[j - 1].CompareTo(list[j]) > 0)
                {
                    // swap element into correct place
                    var tmp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = list[j];

                    // update j to new position for next swap
                    j--;
                }
            }

            return list;
        }
    }
}
