/*

Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

[10, 343445353, 3453445, 3453545353453] should return 3453455.

*/

public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
  {
    //Code here...
    int min1, min2;
    min1 = numbers[0];
    if (numbers[1] < min1){
      min2 = min1;  
      min1 = numbers[1];
    }
    else{
      min2 = numbers[1];
    }
    
    for (int i = 2; i < numbers.Length; i++)
    {
      if (numbers[i] < min2){
        if (numbers[i] < min1){
          min2 = min1;  
          min1 = numbers[i];
        }
        else{
          min2 = numbers[i];
        }
    
      }
    }
    return min1 + min2;
  }
}