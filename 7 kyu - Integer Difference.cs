/*

Write a function that accepts two arguments: an array/list of integers and another integer (n).

Determine the number of times where two integers in the array have a difference of n.

For example:

[1, 1, 5, 6, 9, 16, 27], n=4  -->  3  # (1,5), (1,5), (5,9)
[1, 1, 3, 3], n=2             -->  4  # (1,3), (1,3), (1,3), (1,3)

*/

using System; 

public class Kata
{
  public static int IntDiff(int[] arr, int n)
  {
    int res = 0;
    for (int i = 0; i < arr.Length - 1; i++){
      for (int j = i + 1; j < arr.Length; j++){
        if ( Math.Abs((arr[j] - arr[i])) == n){
          res++;
        }
      }
    }  
    return res;
  }
}