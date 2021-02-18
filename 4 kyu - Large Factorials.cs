/*

In mathematics, the factorial of integer n is written as n!. It is equal to the product of n and every integer preceding it. For example: 5! = 1 x 2 x 3 x 4 x 5 = 120

Your mission is simple: write a function that takes an integer n and returns the value of n!.

You are guaranteed an integer argument. For any values outside the non-negative range, return null, nil or None (return an empty string "" in C and C++). For non-negative numbers a full length number is expected for example, return 25! = "15511210043330985984000000" as a string.

For more on factorials, see http://en.wikipedia.org/wiki/Factorial

NOTES:

The use of BigInteger or BigNumber functions has been disabled, this requires a complex solution

I have removed the use of require in the javascript language.

*/

using System;
using System.Collections;


public class Kata
{
  public static string Factorial(int n)
            {
                ArrayList broj = new ArrayList();

                broj.Add(1);
                
                
                for (int i = 2; i <= n; i++)
                {
                    int prenos = 0;
                    int j = 0;
                    for (j = 0; j < broj.Count; j++)
                    {
                        int temp = (int)broj[j] * i + prenos;
                        broj[j] = (temp) % 10;
                        prenos = temp / 10;
                    }
                    j = broj.Count;
                    while (prenos > 0)
                    {
                        broj.Add(prenos % 10);
                        prenos = prenos / 10;
                    }

                }


                broj.Reverse();
                return string.Join("", broj.ToArray());

            }
}

