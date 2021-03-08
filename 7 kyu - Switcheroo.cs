/*

Given a string made up of letters a, b, and/or c, switch the position of letters a and b (change a to b and vice versa). Leave any incidence of c untouched.

Example:

'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'

*/

public class Kata
{
  public static string Switcheroo(string x)
  {
    x = x.Replace("a", "x");
    x = x.Replace("b", "a");
    x = x.Replace("x", "b");
    return x;
  }
}