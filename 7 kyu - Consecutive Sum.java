/*
Let's say we have a number, num. Find the number of values of n such that: there exists n consecutive positive values that sum up to num. A positive number is > 0. n can also be 1.

#Examples
num = 1
#1
return 1

num = 15
#15, (7, 8), (4, 5, 6), (1, 2, 3, 4, 5)
return 4

num = 48
#48, (15, 16, 17)
return 2

num = 97
#97, (48, 49)
return 2
The upper limit is 10^8
*/

public class Kata{
  public static int consecutiveSum(int num){
        int count = 0;
        for (int i = 1; i * (i + 1) < 2 * num; i++)
        {
            double a = (double) ((1.0 * num - (i * (i + 1)) / 2) / (i + 1));
            if ( a == (int)a )
                count++;
        }
        count++;
        return count;
  }
}