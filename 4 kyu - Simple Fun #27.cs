/*

https://www.codewars.com/kata/5886e082a836a691340000c3

Task
A rectangle with sides equal to even integers a and b is drawn on the Cartesian plane. Its center (the intersection point of its diagonals) coincides with the point (0, 0), but the sides of the rectangle are not parallel to the axes; instead, they are forming 45 degree angles with the axes.

How many points with integer coordinates are located inside the given rectangle (including on its sides)?

Example
For a = 6 and b = 4, the output should be 23

The following picture illustrates the example, and the 23 points are marked green.



Input/Output
[input] integer a

A positive even integer.

Constraints: 2 ? a ? 10000.

[input] integer b

A positive even integer.

Constraints: 2 ? b ? 10000.

[output] an integer

The number of inner points with integer coordinates.


*/

using System;

namespace myjinxin
{
    using System;
    
        public class Kata
        {
            public  int RectangleRotation(int a, int b)
            {
              
              double root = Math.Sqrt(2);
              int r1x = (int)Math.Floor((a / 2 / root)) * 2 + 1;
              int r1y = (int)Math.Floor((b / 2 / root)) * 2 + 1;
              int r2x = (int)Math.Floor((((a - root) / 2 / root)) + 1) * 2;
              int r2y = (int)Math.Floor((((b - root) / 2 / root)) + 1) * 2;       
              return (int)(r1x * r1y + r2x * r2y);
              
            }
        }
    
}