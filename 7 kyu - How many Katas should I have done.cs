/*

As a good developer you have to practice a lot. One way to achieve this is to finish one kata every day after work.

But of course you won't have time for that every day. So maybe you skip one week and think you can do two katas every day in the following week. But of course you lose track of how many katas you should have finished until today.

To control yourself, write a function which gets the start date of your codewars registration and returns how many katas you should have finished until today. We will ignore public holidays.

Example:.

var registrationDate = new DateTime(2018, 01, 01);
var solvedKatas = KataCalculator.SolvedKatasSince(registrationDate, DateTime.Today);

FUNDAMENTALSDATES/TIME

*/

using System;

public class KataCalculator
{
  public static int SolvedKatasSince(DateTime registrationDate, DateTime currentDate)
  {
      int count = 0;
      for (var day = registrationDate; day < currentDate; day = day.AddDays(1))
      {
        if ((day.DayOfWeek != DayOfWeek.Saturday) & (day.DayOfWeek != DayOfWeek.Sunday))
        {
          count++;
        }
      }
      
      return count;
  }
}

