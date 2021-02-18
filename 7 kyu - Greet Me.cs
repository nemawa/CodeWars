/*

Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

Example:

"riley" --> "Hello Riley!"
"JACK"  --> "Hello Jack!"
FUNDAMENTALSSTRINGS

*/

using System;

public static class Kata
{
        public static string Greet(string name)
        {
            return "Hello " + name[0].ToString().ToUpper() + name.Substring(1).ToLower() + "!";
        }
}