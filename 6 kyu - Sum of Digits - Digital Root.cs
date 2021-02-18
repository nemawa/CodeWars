/*

Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

Examples
    16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

*/

using System.Collections.Generic;
using System;

public class Number
{
  public int DigitalRoot(long n)
  {
               // Your awesome code here!

            List<int> res = new List<int>();
            res = ToList(n);
            long temp = 0;
            while (res.Count > 1)
            {
                temp = DoIt(res);
                res = ToList(temp);
            }
            return Convert.ToInt32(temp);


        }
        public List<int> ToList(long x)
        {
            List<int> res = new List<int>();
            while (x > 0)
            {
                res.Add(Convert.ToInt32(x % 10));
                
                x /= 10;
            }
            return res;
        }

        public long DoIt(List<int> x)
        {
            long sum = 0;
            foreach (int i in x)
            {
                sum += i;
            }
            return sum;
        }
  
}