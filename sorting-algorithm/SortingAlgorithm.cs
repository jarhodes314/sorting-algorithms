using System;
using System.Collections.Generic;

namespace sorting_algorithm
{
    public abstract class SortingAlgorithm
    {
        public abstract override string ToString();

        public abstract List<T> Sort<T>(List<T> list) where T : IComparable<T>;
    }
}

