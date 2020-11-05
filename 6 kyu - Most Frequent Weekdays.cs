/*
What is your favourite day of the week? Check if it's the most frequent day of the week in the year.

You are given a year as integer (e. g. 2001). You should return the most frequent day(s) of the week in that year. The result has to be a list of days sorted by the order of days in week (e. g. ['Monday', 'Tuesday'], ['Saturday', 'Sunday'], ['Monday', 'Sunday']). Week starts with Monday.

Input: Year as an int.

Output: The list of most frequent days sorted by the order of days in week (from Monday to Sunday).

Preconditions:

Week starts on Monday.
Year is between 1583 and 4000.
Calendar is Gregorian.
Example:

Kata.MostFrequentDays(2427) == {"Friday"}
Kata.MostFrequentDays(2185) == {"Saturday"}
Kata.MostFrequentDays(2860) == {"Thursday", "Friday"}

*/

using System;
using System.Collections.Generic;

public class Kata
{
  public static string[] MostFrequentDays(int year)
  {
     List<string> res = new List<string>();

            var dt = new DateTime(year, 1, 1);

            res.Add(dt.DayOfWeek.ToString());
            if (DateTime.IsLeapYear(year))
            {
               if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dt = dt.AddDays(1);
                        res.Insert(0, dt.DayOfWeek.ToString());
                    }
                    else
                    {

                        dt = dt.AddDays(1);
                        res.Add(dt.DayOfWeek.ToString());
                    }
            }
         
            return res.ToArray();
  }
}