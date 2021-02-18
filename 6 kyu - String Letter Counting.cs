/*

Take an input string and return a string that is made up of the number of occurences of each english letter in the input followed by that letter, sorted alphabetically. The output string shouldn't contain chars missing from input (chars with 0 occurence); leave them out.

An empty string, or one with no letters, should return an empty string.

Notes:

the input will always be valid;
treat letters as case-insensitive
Examples
"This is a test sentence."  ==>  "1a1c4e1h2i2n4s4t"
""                          ==>  ""
"555"                       ==>  ""

*/

using System;
using System.Collections.Generic;
using System.Text;

public class Kata
{
  public static string StringLetterCount(string str)
  {
    SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
    
    str = str.ToLower();
    
    foreach(char c in str)
    {
      if ((c >= 'a') & (c <= 'z'))
      {
        if (dict.ContainsKey(c))
        {
          dict[c] = dict[c] + 1;
        }
        else
        {
          dict.Add(c, 1);
        }
        
      }
    }

    StringBuilder res = new StringBuilder(String.Empty);
    foreach (KeyValuePair<char, int> c in dict)
    {
      res.Append(c.Value);
      res.Append(c.Key);
      
    }
    return res.ToString();
    //Your code
  }
}