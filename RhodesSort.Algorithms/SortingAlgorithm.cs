using System;
using System.Collections.Generic;

namespace RhodesSort.Algorithms
{
    public abstract class SortingAlgorithm
    {
        public abstract override string ToString();

        public abstract List<T> Sort<T>(List<T> list) where T : IComparable<T>;
    }
}

