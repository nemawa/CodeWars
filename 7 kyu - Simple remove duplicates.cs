/*

In this Kata, you will remove the left-most duplicates from a list of integers and return the result.

// Remove the 3's at indices 0 and 3
// followed by removing a 4 at index 1
solve([3, 4, 4, 3, 6, 3]); // => [4, 6, 3]
More examples can be found in the test cases.

Good luck!

*/

using System;
using System.Collections.Generic;

public class Solution
{
    public static int [] solve (int [] arr){
      //..  
      List<int> res = new List<int>();
      for (int i = 0; i < arr.Length; i++)
      {
        bool ok = false;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[i]==arr[j]) ok = true;
        }
        if (!ok) 
        {
          res.Add(arr[i]);
        }
      }
      return res.ToArray();
    }
}

