﻿using System;
using System.Collections.Generic;

namespace RhodesSort.Algorithms
{
    public class FisherYates
    {
        /* Fisher-Yates is a shuffling algorithm
         * it avoids the bias that more naïve methods
         * introduce
         * 
         * this is used to animate shuffling the list
         * in sorting-visualiser
         */

        public static IList<T> Shuffle<T>(IList<T> list)
        {
            // create new pre-seeded (pseudo)random number generator 
            var randomGen = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = randomGen.Next(0, i);
                var temp = list[i];

                list[i] = list[j];
                list[j] = temp;
            }

            return list;
        }
    }
}
