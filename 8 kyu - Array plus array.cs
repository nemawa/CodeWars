/*

I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.

*/

using System.Linq;

public static class Kata
{
  public static int ArrayPlusArray(int[] arr1, int[] arr2)
  {
    int res = arr1.Sum() + arr2.Sum();
    
    return res;
  }
}
