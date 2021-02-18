/*

Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 42145 Output: 54421

Input: 145263 Output: 654321

Input: 123456789 Output: 987654321

*/

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    List<int> res = new List<int>();
    if (num == 0) return 0;
    while (num > 0){
      res.Add(num % 10);
      num /= 10;
    }
    res.Sort();
    res.Reverse();
    
    int result = 0;
    for (int i = 0; i < res.Count(); i++)
    {
      result = result * 10 + res[i];
    }
    // Bust a move right here
    return result;
  }
}