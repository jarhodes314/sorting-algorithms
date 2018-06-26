using System;
using System.Collections.Generic;

namespace RhodesSort.Algorithms
{
    public abstract class SortingAlgorithm
    {
        public abstract override string ToString();

        public abstract IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
    }
}

