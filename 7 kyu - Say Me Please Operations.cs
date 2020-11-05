/*
You have a string of numbers; starting with the third number each number is the result of an operation performed using the previous two numbers.

Complete the function which returns a string of the operations in order and separated by a comma and a space, e.g. "subtraction, subtraction, addition"

The available operations are (in this order of preference):

1) addition
2) subtraction
3) multiplication
4) division
Notes:

All input data is valid
The number of numbers in the input string >= 3
For a case like "2 2 4" - when multiple variants are possible - choose the first possible operation from the list (in this case "addition")
Integer division should be used
Example
"9 4 5 20 25"  -->  "subtraction, multiplication, addition"
Because:

9 - 4 = 5   --> subtraction
4 * 5 = 20  --> multiplication
5 + 20 = 25 --> addition
*/

using System.Collections.Generic;
using System.Linq;
using System;


public class Kata
{
      public static string sayMeOperations(string  stringNumbers)
      {
          // :) ...
          int[] num = stringNumbers.Split(' ').Select(Int32.Parse).ToArray();
          int old = num[0];
          string res = "";
          for(int i = 1; i < num.Length -1; i ++)
          {
              if (old + num[i] == num[i+1]) 
              {
                if (res == "")
                {
                  res = "addition";
                }
                else
                {
                  res += ", addition";
                }
                old = num[i];
                
              }
              else if (old - num[i] == num[i+1])
              {
                if (res == "")
                {
                  res = "subtraction";
                }
                else
                {
                  res += ", subtraction";
                }
                old = num[i];
              }
              else if (old * num[i] == num[i+1])
              {
                if (res == "")
                {
                  res = "multiplication";
                }
                else
                {
                  res += ", multiplication";
                }
                old = num[i];
              }
              else if (old / num[i] == num[i+1])  
              {
                if (res == "")
                {
                  res = "division";
                }
                else
                {
                  res += ", division";
                }
                old = num[i];
              }
                
          }
          return res;
      }
}