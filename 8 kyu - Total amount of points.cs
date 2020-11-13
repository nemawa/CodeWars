/*

Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.

For example: ["3:1", "2:2", "0:1", ...]

Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:

if x>y - 3 points
if x<y - 0 point
if x=y - 1 point
Notes:

there are 10 matches in the championship
0 <= x <= 4
0 <= y <= 4

*/

using System.Linq;
using System;

public static class Kata {
    public static int TotalPoints(string[] games) {
        // insert magic here
        int points = 0;
        foreach( string s in games)
        {
          int i = Int32.Parse(s[0].ToString());
          int j = Int32.Parse(s[2].ToString());
          
          if (i > j) points += 3;
          if (i == j) points += 1;
          

        
        }
        return points;
    }
}