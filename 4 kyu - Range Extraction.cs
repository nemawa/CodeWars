/*

A format for expressing an ordered list of integers is to use a comma separated list of either

individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-6,-3-1,3-5,7-11,14,15,17-20"
Courtesy of rosettacode.org

*/

using System.Text;

public class RangeExtraction
{
 public static string Extract(int[] args)
    {
        int actual = 0;
        StringBuilder res = new StringBuilder();
        while (actual < args.Length)
        {
            if (actual + 2 < args.Length)
            {
                if ((args[actual] + 1 == args[actual + 1]) && (args[actual + 1] + 1 == args[actual + 2]))
                {
                    if (res.Length != 0)
                    {
                        res.Append(",");
                    }
                    res.Append(args[actual] + "-");
                    actual++;
                    while ((actual < args.Length - 1) && (args[actual] + 1 == args[actual + 1]))
                    {
                        actual++;
                    }
                    res.Append(args[actual]);
                    //actual++;
                }
                else
                {
                    if (res.Length != 0)
                        res.Append(",");
                    res.Append(args[actual]); 
                }
            }
            else 
            {
                if (res.Length != 0)
                    res.Append(",");
                res.Append(args[actual]);

            }
            actual++;
        }

        return res.ToString();  //TODO
    }
}