/*

Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

Example:

my_list = ['Keep', 'Remove', 'Keep', 'Remove', 'Keep', ...]
None of the arrays will be empty, so you don't have to worry about that!

*/

using System.Collections.Generic;
using System;

  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            var x = new List<Object>();
            
            for (int i = 0; i < arr.Length; i = i + 2)
            {
              x.Add(arr[i]);
            }
            // happy coding
            return x.ToArray();
        }
    }
	
	