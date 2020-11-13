/*

Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

Patrick Feeney => P.F

*/

public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] newS = name.Split(" ");
    
    return (newS[0][0] + "." + newS[1][0]).ToUpper();
  }
}