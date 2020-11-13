/*

Given a positive number n > 1 find the prime factor decomposition of n. The result will be a string with the following form :

 "(p1**n1)(p2**n2)...(pk**nk)"
where a ** b means a to the power of b

with the p(i) in increasing order and n(i) empty if n(i) is 1.

Example: n = 86240 should return "(2**5)(5)(7**2)(11)"

*/

using System;
using System.Text;

public class PrimeDecomp {

  public static String factors(int lst) {
  
    StringBuilder res = new StringBuilder();
    
    for (int i = 2; i <= lst; i++)
    {
      if (lst % i == 0)
      {
        int count = 0;
        while (lst % i == 0)
        {
          count++;
          lst = lst / i;
          
        }
        if (count > 1)
        {
          res.Append($"({i}**{count})");
        }
        else
        {
          res.Append($"({i})");
        }
      }
    }
    return res.ToString();
  }
}