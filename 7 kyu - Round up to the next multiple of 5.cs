/*

Given an integer as input, can you round it to the next (meaning, "higher") multiple of 5?

Examples:

input:    output:
0    ->   0
2    ->   5
3    ->   5
12   ->   15
21   ->   25
30   ->   30
-2   ->   0
-5   ->   -5
etc.
Input may be any positive or negative integer (including 0).

You can assume that all inputs are valid integers.

FUNDAMENTALS

*/

using System;

public class Kata
{
  public static int RoundToNext5(int n)
  {
    int rest = n % 5;
    if (rest == 0) return n;
    else
    {
      if (n > 0)
      {
        return n + (5 - rest);
      }
      if (n < 0)
      {
        return n + (Math.Abs(rest));
      }
      
    } 
    return 0;
    //Your code goes here...
  }
}