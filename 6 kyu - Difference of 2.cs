/*

The objective is to return all pairs of integers from a given array of integers that have a difference of 2.

The result array should be sorted in ascending order of values.

Assume there are no duplicate integers in the array. The order of the integers in the input array should not matter.

Examples
[1, 2, 3, 4]  should return [[1, 3], [2, 4]]

[4, 1, 2, 3]  should also return [[1, 3], [2, 4]]

[1, 23, 3, 4, 7] should return [[1, 3]]

[4, 3, 1, 5, 6] should return [[1, 3], [3, 5], [4, 6]]

*/

using System;
using System.Collections;
using System.Collections.Generic;

 public class Kata
    {
        public static (int, int)[] TwosDifference(int[] array)
        {
            Array.Sort(array);
            var res = new List<(int, int)>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                while ((j < array.Length) && (array[j] - 2 <= array[i]))
                {
                    if (array[i] + 2 == array[j])
                    {
                        res.Add((array[i], array[j]));
                    }
                    j++;
                }
            }
            return res.ToArray();
        }

  
    }
	
	