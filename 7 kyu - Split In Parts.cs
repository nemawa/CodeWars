/*

The aim of this kata is to split a given string into different strings of equal size (note size of strings is passed to the method)

Example:

Split the below string into other strings of size #3

'supercalifragilisticexpialidocious'

Will return a new string
'sup erc ali fra gil ist ice xpi ali doc iou s'
Assumptions:

String length is always greater than 0
String has no spaces
Size is always positive

*/

using System;
using System.Linq;
using System.Text;

public class Kata
{
  public static string SplitInParts(string s, int partLength)
  {  
    
    StringBuilder res = new StringBuilder("");
    for (int i = 0; i < s.Length; i++)
    {
      res.Append(s[i]);
      if ((i % partLength == partLength -1) & (i != s.Length -1 )) res.Append(" ");
    }
    return res.ToString();
  }
}  