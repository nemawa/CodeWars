/*

Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

*/

using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
               // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)
            List<int> result = new List<int>();
            int j;
            bool res;
            for (int i = 0; i < a.Length; i++)
            {
                res = true;
                j = 0;
                while ((j < b.Length) & res)
                {
                    if (a[i] == b[j]) res = false;
                    j++;
                }
                if (res) result.Add(a[i]);
                else res = true;
            }
            return result.ToArray();
  }
}