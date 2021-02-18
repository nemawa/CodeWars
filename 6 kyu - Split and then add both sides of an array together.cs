/*

Inspired by the Fold an Array kata. This one is sort of similar but a little different.

Task
You will receive an array as parameter that contains 1 or more integers and a number n.

Here is a little visualization of the process:

Step 1: Split the array in two:

[1, 2, 5, 7, 2, 3, 5, 7, 8]
      /            \
[1, 2, 5, 7]    [2, 3, 5, 7, 8]
Step 2: Put the arrays on top of each other:

   [1, 2, 5, 7]
[2, 3, 5, 7, 8]
Step 3: Add them together:

[2, 4, 7, 12, 15]
Repeat the above steps n times or until there is only one number left, and then return the array.

Example
Input: arr=[4, 2, 5, 3, 2, 5, 7], n=2


Round 1
-------
step 1: [4, 2, 5]  [3, 2, 5, 7]

step 2:    [4, 2, 5]
        [3, 2, 5, 7]

step 3: [3, 6, 7, 12]


Round 2
-------
step 1: [3, 6]  [7, 12]

step 2:  [3,  6]
         [7, 12]

step 3: [10, 18]


Result: [10, 18]

*/

using System.Collections.Generic;

namespace Solution 
{
  public class Kata 
  {
    public static int[] SplitAndAdd(int[] numbers, int n) 
    {
      List<int> temp = new List<int>(numbers);
      for (int i = 0; i < n; i++)
      {
        var novi = DoIt(temp);
        temp = novi;
               
        
      }// your code
      return temp.ToArray();
    }
    
    public static List<int> DoIt(List<int> temp)
    {
      List<int> novi = new List<int>();
      int step = 0;
      if (temp.Count % 2 == 1)
      {
        step = 1;
        novi.Add(temp[temp.Count / 2]);
      }
      for (int i = 0; i < temp.Count / 2; i++)
      {
        novi.Add(temp[i] + temp[temp.Count / 2 +  i + step]);
      }
      return novi;
    }
  }
}