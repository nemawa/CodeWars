/*

Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

*/

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
                int s = input.Length;
                int countX = 0;
                int countO = 0;
                for (int i=0; i < s; i++)
                {
                    if (input[i] == 'x' || input[i] == 'X' )
                    {
                        countX++;
                    }
                    if (input[i] == 'o' || input[i] == 'O')
                    {
                        countO++;
                    }
                }


                return countO == countX;
    
  }
}