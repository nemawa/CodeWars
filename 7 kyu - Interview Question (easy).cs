/*
You receive the name of a city as a string, and you need to return a string that shows how many times each letter shows up in the string by using an asterisk (*).

For example:

"Chicago"  -->  "c:**,h:*,i:*,a:*,g:*,o:*"
As you can see, the letter c is shown only once, but with 2 asterisks.

The return string should include only the letters (not the dashes, spaces, apostrophes, etc). There should be no spaces in the output, and the different letters are separated by a comma (,) as seen in the example above.

Note that the return string must list the letters in order of their first appearence in the original string.

More examples:

"Bangkok"    -->  "b:*,a:*,n:*,g:*,k:**,o:*"
"Las Vegas"  -->  "l:*,a:**,s:**,v:*,e:*,g:*"
Have fun! ;)
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string GetStrings(string city)
    {
        List<Char> count = new List<Char>();
        string res = "";
        city = city.ToLower();      
        for (int i = 0; i < city.Length; i++)      
        {
            if ((city[i] >= 'a') && (city[i] <= 'z'))
            {
              if (!(count.Contains(city[i])))
              {
                int c = 0;
                for (int j = 0; j < city.Length; j++)
                {
                  if (city[i] == city[j]) c++;
                }
                if (res != "") res += ",";
                res += city[i] + ":";
                for (int w = 0; w < c; w++)
                {
                  res += "*";
                }
                count.Add(city[i]);
              }
            }
        }
        
        
        
        return res; //stringname;
    }
}