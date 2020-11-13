/*

Is the string uppercase?
Task
Create an extension method IsUpperCase to see whether the string is ALL CAPS. For example:

"c".IsUpperCase() == false
"C".IsUpperCase() == true
"hello I AM DONALD".IsUpperCase() == false
"HELLO I AM DONALD".IsUpperCase() == true
"ACSKLDFJSgSKLDFJSKLDFJ".IsUpperCase() == false
"ACSKLDFJSGSKLDFJSKLDFJ".IsUpperCase() == true
In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string containing no letters at all is trivially considered to be in ALL CAPS.

*/

using System; 
public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    foreach (Char c in text)
    {
      if (Char.IsLower(c)) return false;
    }
    return true;
  }
}
