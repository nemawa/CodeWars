/*

An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "aba" == false
isIsogram "moOse" == false -- ignore letter case

*/

using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    string s = str.ToLower();
    for ( int i=0; i<s.Length-1; i++){
      for (int j=i+1; j<s.Length; j++)
        if (s[i] == s[j]){
          return false;
        }
    }
    return true;
    // Code on you crazy diamond!
  }
}