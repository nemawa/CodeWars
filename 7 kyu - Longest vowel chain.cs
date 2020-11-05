/*
The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

Documentation:
Kata.Solve Method (String)
Returns the length of the greatest continuous vowel substring in a string.

Syntax

public static int Solve(
string str
)
Parameters
str
Type: System.String
The string to be processed.

Return Value
Type: System.Int32
The length of the greatest continuous vowel substring in str, or 0 if str contains no vowels.


Exceptions
Exception	Condition
ArgumentNullException	str is null.

Good luck!
*/

using System;

public static class Kata
{
  public static int Solve(string str)
  {
    int res = 0;
    Console.WriteLine(str);
    for (int i = 0; i < str.Length; i++)
    {
      if ("aeiou".IndexOf(str[i]) >= 0)
      {
        int j = i;
        do 
        {
          j++;
        }
        while ((j < str.Length) && ("aeiou".IndexOf(str[j]) >= 0));
        if (j - i > res) res = j - i;
      }
    }
    return res;
    throw new NotImplementedException();
  }
}