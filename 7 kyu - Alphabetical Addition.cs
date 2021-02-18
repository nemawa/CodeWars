/*

Your task is to add up letters to one letter.

The function will be given an array of letters (chars), each one being a letter to add. Return a char.

Notes:
Letters will always be lowercase.
Letters can overflow (see second to last example of the description)
If no letters are given, the function should return 'z'
Examples:
AddLetters(new char[] {'a', 'b', 'c'}) = 'f'
AddLetters(new char[] {'a', 'b'}) = 'c'
AddLetters(new char[] {'z'}) = 'z'
AddLetters(new char[] {'z', 'a'}) = 'a'
AddLetters(new char[] {'y', 'c', 'b'}) = 'd' // notice the letters overflowing
AddLetters(new char[] {}) = 'z'
Confused? Roll your mouse/tap over here

*/

using System;

public class Kata {
  public static char AddLetters(char[] letters) {
    int res = 0;
    if (letters.Length == 0){
    return 'z';
    }
    else{
      foreach(char c in letters){
        res += c -96;
      }
      while (res>26){
        res -=26;
      }
      return (char)(res+96);
    }
    // your code here
  }
}