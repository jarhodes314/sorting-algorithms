using System;
using System.Collections.Generic;
using System.Text;

namespace RhodesSort.Algorithms
{
    public class MergeSort : SortingAlgorithm
    {
        private IList<T> Merge<T>(IList<T> A, int iLeft, int iRight, int iEnd, IList<T> B) where T : IComparable<T>
        {
            var i = iLeft;
            var j = iRight;

            for (var k = iLeft; k < iEnd; k++)
            {
                if (i < iRight && (j >= iEnd || A[i].CompareTo(A[j]) <= 0))
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
            }

            return B;
        }

        public override IList<T> Sort<T>(IList<T> list)
        {
            List<T> space = new List<T>(list.Count);

            int j = 0;
            foreach (var item in list)
            {
                space.Add(item);
            }

            for (var width = 1; width < list.Count; width *= 2)
            {
                for(var i = 0; i < list.Count; i += 2 * width)
                {
                    Merge<T>(list, i, Math.Min(i + width, list.Count), Math.Min(i + 2 * width, list.Count), space);
                }

                j = 0;
                foreach (var item in space)
                {
                    Console.Write(item);
                    list[j++] = item;
                }
            }


            return list;
        }

        public MergeSort()
        {
            SpeedMultiplier = 1;
        }

        public override string ToString()
        {
            return "Mergesort";
        }
    }
}
