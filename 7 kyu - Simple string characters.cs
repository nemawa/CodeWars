/*
In this Kata, you will be given a string and your task will be to return a list of ints detailing the count of uppercase letters, lowercase, numbers and special characters, as follows.

Solve("*'&ABCDabcde12345") = [4,5,5,3]. 
--the order is: uppercase letters, lowercase, numbers and special characters.
More examples in the test cases.

Good luck!
*/

using System;

public class Solution
{
    public static int [] solve(String s){
      int uc = 0;
      int lc = 0;
      int nu = 0;
      int sc = 0;
      foreach (Char c in s)
      {
        if ( Char.IsDigit(c)) nu++;
        else if (Char.IsLower(c)) lc++;
        else if (Char.IsUpper(c)) uc++;
        else sc++;
        
          
      }
      return new int[]{uc, lc, nu, sc};
        //..
    }
}