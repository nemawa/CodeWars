/*

In the following 6 digit number:

283910
91 is the greatest sequence of 2 consecutive digits.

In the following 10 digit number:

1234567890
67890 is the greatest sequence of 5 consecutive digits.

Complete the solution so that it returns the greatest sequence of five consecutive digits found within the number given. The number will be passed in as a string of only digits. It should return a five digit integer. The number passed may be as large as 1000 digits.

Adapted from ProjectEuler.net

*/

using System;
using System.Collections.Generic;

public class Kata 
{
  public static int GetNumber(string str) 
  {
    string test = str.Substring(0, 5);
    for (int i = 1; i < str.Length - 4; i++)
    {
      string sub = str.Substring(i, 5);
      if (String.CompareOrdinal(sub, test) > 0)
      {
        test = sub;
      }
    }
    return Int32.Parse(test);
  }
}
