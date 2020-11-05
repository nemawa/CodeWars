/*
Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/

using System;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    string res = "";
    
    string banned = "aeiouAEIUO";
    char[] temp = str.ToCharArray();
    foreach (Char c in temp)
    {
      if (banned.IndexOf(c) < 0)
        res += c.ToString();
    }
    return res;
  }
}