/*

Your task, is to create a NxN spiral with a given size.

For example, spiral with size 5 should look like this:

00000
....0
000.0
0...0
00000
and with the size 10:

0000000000
.........0
00000000.0
0......0.0
0.0000.0.0
0.0..0.0.0
0.0....0.0
0.000000.0
0........0
0000000000
Return value should contain array of arrays, of 0 and 1, for example for given size 5 result should be:

[[1,1,1,1,1],[0,0,0,0,1],[1,1,1,0,1],[1,0,0,0,1],[1,1,1,1,1]]
Because of the edge-cases for tiny spirals, the size will be at least 5.

General rule-of-a-thumb is, that the snake made with '1' cannot touch to itself.

*/

public class Spiralizor
{
 public static int[,] Spiralize(int size)
    {
        // Happy coding...
        int[,] res = new int[size, size];

        int top = 0;
        int bot = size - 1;
        int left = 0;
        int right = size - 1;

        int i = 0, j = 0;

        while ((top <= bot) || (left <= right))
        {

            while ((i <= right) && (bot >= top))
            { 
                res[j, i] = 1;
                i++;
            }
            i--;
            top = j + 2;


            while ((j <= bot) && (left <= right))
            {
                res[j, i] = 1;
                j++;
            }
            j--;
            right = i - 2;

            
            while ((i >= left) && (bot >= top))
            {
                res[j, i] = 1;
                i--;
            }
            i++;
            bot = j - 2;
            j--;
            while ((j >= top) && (left <= right))
            {
                res[j, i] = 1;
                j--;
            }
            j++;
            left = i + 2;
        }
        return res;
    }
}