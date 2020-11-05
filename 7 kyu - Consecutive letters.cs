/*
In this Kata, we will check if a string contains consecutive letters as they appear in the English alphabet and if each letter occurs only once.

Rules are: (1) the letters are adjacent in the English alphabet, and (2) each letter occurs only once.

For example: 
solve("abc") = True, because it contains a,b,c
solve("abd") = False, because a, b, d are not consecutive/adjacent in the alphabet, and c is missing.
solve("dabc") = True, because it contains a, b, c, d
solve("abbc") = False, because b does not occur once.
solve("v") = True
All inputs will be lowercase letters.

More examples in test cases. Good luck!
*/

using System;

public class Solution
{
    public static bool solve(string s){  
      Char[] temp = new Char[s.Length];
      
      for (int i = 0; i < s.Length; i++)
      {
        temp[i] = s[i];
      }
      Array.Sort(temp);
      if (temp.Length == 1) return true;
      bool ok = true;
      int j = 0;
      while ((j < s.Length - 1) && (ok))
      {
        if (temp[j + 1] - temp[j] != 1) return false;
        j++;
      }
      return ok;
    }
}