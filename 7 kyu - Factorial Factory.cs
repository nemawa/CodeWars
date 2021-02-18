/*

In mathematics, the factorial of integer 'n' is written as 'n!'. It is equal to the product of n and every integer preceding it. For example: 5! = 1 x 2 x 3 x 4 x 5 = 120

Your mission is simple: write a function that takes an integer 'n' and returns 'n!'.

You are guaranteed an integer argument. For any values outside the positive range, return null, nil or None .

Note: 0! is always equal to 1. Negative values should return null;

For more on Factorials : http://en.wikipedia.org/wiki/Factorial


*/

using System;

public static class Kata
{
  public static int Factorial(int n)
  {
     if (n==0) {return 1;}
     else if(n<0){throw null;}
     else {
       int i = 1;
       for (int j=1; j<=n; j++){
         i *= j;
       }
       return i;
     }// Return factorial of n
  }
}