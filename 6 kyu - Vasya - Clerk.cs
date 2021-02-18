/*

The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.

Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?

Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO.

Examples:
Line.Tickets(new int[] {25, 25, 50}) // => YES 
Line.Tickets(new int[] {25, 100}) // => NO. Vasya will not have enough money to give change to 100 dollars
Line.Tickets(new int[] {25, 25, 50, 50, 100}) // => NO. Vasya will not have the right bills to give 75 dollars of change (you can't make two bills of 25 from one of 50)


*/

using System;
using System.Collections.Generic;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
          List<int> cach = new List<int> { 0, 0, 0 }; 

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25) cach[0] += 1;
                if (peopleInLine[i] == 50) cach[1] += 1;
                if (peopleInLine[i] == 100) cach[2] += 1;



                if (peopleInLine[i] != 25)
                {
                    if (peopleInLine[i] == 50) // dosao sa 50
                    {
                        if (cach[0] == 0)
                        {
                            return "NO";
                        }
                        else
                        {
                            cach[0] -= 1;
                        }
                    }

                    // dosao sa 100  dva slucaja
                    if (peopleInLine[i] == 100)
                    {
                        if ((cach[1] >= 1) & (cach[0] >= 1))
                        {
                            cach[1] -= 1;
                            cach[0] -= 1; //vraca 50 i 25
                        }
                        else if (cach[0] >= 3)
                        {
                            cach[0] -= 3;
                        }
                        else
                        {
                            return ("NO");
                        }
                    }

                }


            }

            return ("YES");
           
           //Your code is here...
        }
    }